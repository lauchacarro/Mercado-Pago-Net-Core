// Decompiled with JetBrains decompiler
// Type: MercadoPago.MPBase
// Assembly: MercadoPago, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C24A3BA-51C0-4EAB-8180-D4EA12994FDF
// Assembly location: C:\Users\Laucha\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\MercadoPago.dll

using MercadoPago.DataStructures.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MercadoPago
{
    public abstract class MPBase
    {
        public static bool WITHOUT_CACHE = false;
        public static bool WITH_CACHE = true;
        public static List<string> ALLOWED_BULK_METHODS = new List<string>()
    {
      "All",
      "Search"
    };
        public static string DataTypeError = "Error on property #PROPERTY. The value you are trying to assign has not the correct type. ";
        public static string RangeError = "Error on property #PROPERTY. The value you are trying to assign is not in the specified range. ";
        public static string RequiredError = "Error on property #PROPERTY. There is no value for this required property. ";
        public static string RegularExpressionError = "Error on property #PROPERTY. The specified value is not valid. RegExp: #REGEXPR . ";
        protected MPAPIResponse _lastApiResponse;
        protected JObject _lastKnownJson;
        protected BadParamsError? _errors;
        protected string _marketplaceAccessToken;
        protected readonly SDK sdk;
        public MPBase(SDK sdk)
        {
            this.sdk = sdk;
        }

        public static string IdempotencyKey { get; set; }

        public BadParamsError? Errors
        {
            get
            {
                return this._errors;
            }
            private set
            {
                this._errors = value;
            }
        }

        public string MarketplaceAccessToken
        {
            get
            {
                return this._marketplaceAccessToken;
            }
            set
            {
                this._marketplaceAccessToken = value;
            }
        }

        public bool ShouldSerializeMarketplaceAccessToken()
        {
            return false;
        }

        public void DelegateErrors(BadParamsError DelegatedErrors)
        {
            this._errors = new BadParamsError?(DelegatedErrors);
        }

        public MPAPIResponse GetLastApiResponse()
        {
            return this._lastApiResponse;
        }

        public JObject GetLastKnownJson()
        {
            return this._lastKnownJson;
        }

        public static void AdmitIdempotencyKey(Type classType)
        {
            foreach (Attribute customAttribute in classType.GetCustomAttributes(true))
            {
                if (customAttribute.GetType() == typeof(Idempotent))
                    MPBase.IdempotencyKey = customAttribute.GetType().GUID.ToString();
            }
        }

        public static List<T> ProcessMethodBulk<T>(Type clazz, string methodName, bool useCache, SDK sdk) where T : MPBase
        {
            Dictionary<string, string> mapParams = (Dictionary<string, string>)null;
            return MPBase.ProcessMethodBulk<T>(clazz, methodName, mapParams, useCache, sdk);
        }

        public static List<T> ProcessMethodBulk<T>(
          Type clazz,
          string methodName,
          string param1,
          bool useCache, SDK sdk)
          where T : MPBase
        {
            return MPBase.ProcessMethodBulk<T>(clazz, methodName, new Dictionary<string, string>()
      {
        {
          nameof (param1),
          param1
        }
      }, useCache, sdk);
        }

        public static MPBase ProcessMethod(string methodName, bool useCache, SDK sdk)
        {
            Type typeFromStack = MPBase.GetTypeFromStack();
            MPBase.AdmitIdempotencyKey(typeFromStack);
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            return MPBase.ProcessMethod<MPBase>(typeFromStack, (MPBase)null, methodName, parameters, useCache, sdk);
        }

        public static MPBase ProcessMethod<T>(
          Type type,
          string methodName,
          string param,
          bool useCache, SDK sdk)
          where T : MPBase
        {
            Type typeFromStack = MPBase.GetTypeFromStack();
            MPBase.AdmitIdempotencyKey(typeFromStack);
            return (MPBase)MPBase.ProcessMethod<T>(typeFromStack, default(T), methodName, new Dictionary<string, string>()
      {
        {
          "id",
          param
        }
      }, useCache, sdk);
        }

        public static MPBase ProcessMethod<T>(
          Type clazz,
          string methodName,
          string param1,
          string param2,
          bool useCache, SDK sdk)
          where T : MPBase
        {
            return (MPBase)MPBase.ProcessMethod<T>(clazz, default(T), methodName, new Dictionary<string, string>()
      {
        {
          "param0",
          param1
        },
        {
          nameof (param1),
          param2
        }
      }, useCache, sdk);
        }

        public static MPBase ProcessMethod<T>(string methodName, string param, bool useCache, SDK sdk) where T : MPBase
        {
            Type typeFromStack = MPBase.GetTypeFromStack();
            MPBase.AdmitIdempotencyKey(typeFromStack);
            return (MPBase)MPBase.ProcessMethod<T>(typeFromStack, default(T), methodName, new Dictionary<string, string>()
      {
        {
          "id",
          param
        }
      }, useCache, sdk);
        }

        public MPBase ProcessMethod<T>(string methodName, bool useCache, SDK sdk) where T : MPBase
        {
            Dictionary<string, string> parameters = (Dictionary<string, string>)null;
            MPBase.ProcessMethod<T>(this.GetType(), (T)this, methodName, parameters, useCache, sdk);
            return this;
        }

        public bool ProcessMethodBool<T>(string methodName, bool useCache, SDK sdk) where T : MPBase
        {
            Dictionary<string, string> parameters = (Dictionary<string, string>)null;
            MPBase.ProcessMethod<T>(this.GetType(), (T)this, methodName, parameters, useCache, sdk);
            return this.Errors.HasValue;
        }

        protected static List<T> ProcessMethodBulk<T>(
          Type clazz,
          string methodName,
          Dictionary<string, string> mapParams,
          bool useCache, SDK sdk)
          where T : MPBase
        {
            if (!MPBase.ALLOWED_BULK_METHODS.Contains(methodName))
                throw new MPException("Method \"" + methodName + "\" not allowed");
            List<T> objList1 = new List<T>();
            Dictionary<string, object> restInformation = MPBase.GetRestInformation(MPBase.GetAnnotatedMethod(clazz, methodName));
            HttpMethod httpMethod = (HttpMethod)restInformation["method"];
            T resource = default(T);
            string path = MPBase.ParsePath<T>(restInformation["path"].ToString(), mapParams, resource, sdk);
            int retries = (int)restInformation["retries"];
            int requestTimeout = (int)restInformation["requestTimeout"];
            Console.WriteLine("Path: {0}", (object)path);
            PayloadType payloadType = (PayloadType)restInformation["payloadType"];
            WebHeaderCollection standardHeaders = MPBase.GetStandardHeaders();
            MPAPIResponse response = MPBase.CallAPI(httpMethod, path, payloadType, (JObject)null, standardHeaders, useCache, requestTimeout, retries);
            List<T> objList2 = new List<T>();
            if (response.StatusCode >= 200 && response.StatusCode < 300)
                objList2 = MPBase.FillArrayWithResponseData<T>(clazz, response);
            return objList2;
        }

        protected static T ProcessMethod<T>(
          Type clazz,
          T resource,
          string methodName,
          Dictionary<string, string> parameters,
          bool useCache, SDK sdk)
          where T : MPBase
        {
            if ((object)resource == null)
            {
                try
                {
                    resource = (T)Activator.CreateInstance(clazz, sdk);
                }
                catch (Exception ex)
                {
                    throw new MPException(ex.Message);
                }
            }
            Dictionary<string, object> restInformation = MPBase.GetRestInformation(MPBase.GetAnnotatedMethod(clazz, methodName));
            HttpMethod httpMethod = (HttpMethod)restInformation["method"];
            string path = MPBase.ParsePath<T>(restInformation["path"].ToString(), parameters, resource, sdk);
            PayloadType payloadType = (PayloadType)restInformation["payloadType"];
            JObject payload = MPBase.GeneratePayload<T>(httpMethod, resource);
            int requestTimeout = (int)restInformation["requestTimeout"];
            int retries = (int)restInformation["retries"];
            WebHeaderCollection colHeaders = new WebHeaderCollection();
            MPAPIResponse response = MPBase.CallAPI(httpMethod, path, payloadType, payload, colHeaders, useCache, requestTimeout, retries);
            if (response.StatusCode >= 200 && response.StatusCode < 300)
            {
                if (httpMethod != HttpMethod.DELETE)
                {
                    resource = (T)MPBase.FillResourceWithResponseData<T>(resource, response);
                    resource._lastApiResponse = response;
                }
                else
                    resource = default(T);
            }
            else if (response.StatusCode >= 400 && response.StatusCode < 500)
            {
                BadParamsError badParamsError = MPCoreUtils.GetBadParamsError(response.StringResponse);
                resource.Errors = new BadParamsError?(badParamsError);
            }
            else
            {
                MPException mpException = new MPException()
                {
                    StatusCode = new int?(response.StatusCode),
                    ErrorMessage = response.StringResponse,
                    Cause = {
            response.JsonObjectResponse.ToString()
          }
                };
            }
            return resource;
        }

        public static JObject GeneratePayload<T>(HttpMethod httpMethod, T resource) where T : MPBase
        {
            if (httpMethod.ToString() == "PUT")
                return MPBase.getDiffFromLastChange((JToken)MPCoreUtils.GetJsonFromResource<T>(resource), (JToken)resource.GetLastKnownJson());
            if (httpMethod.ToString() == "POST")
                return MPCoreUtils.GetJsonFromResource<T>(resource);
            return (JObject)null;
        }

        public static JObject getDiffFromLastChange(JToken jactual, JToken jold)
        {
            JObject jobject = new JObject();
            if (((JObject)jactual).Properties().Count<JProperty>() <= 0)
                return (JObject)null;
            foreach (JProperty property in ((JObject)jactual).Properties())
            {
                string snakeCase = MPBase.ToSnakeCase(property.Name);
                if (property.Value.GetType() == typeof(JObject))
                {
                    if (jold != null)
                    {
                        JObject diffFromLastChange = MPBase.getDiffFromLastChange(property.Value, jold[(object)property.Name]);
                        if (diffFromLastChange != null && diffFromLastChange.Properties().Count<JProperty>() > 0)
                            jobject.Add(snakeCase, (JToken)diffFromLastChange);
                    }
                    else
                        jobject.Add(snakeCase, property.Value);
                }
                else if (property.Value.GetType() == typeof(JArray))
                    jobject.Add(snakeCase, property.Value);
                else if (property.Value.GetType() == typeof(JValue))
                {
                    if (jold != null)
                    {
                        if (jold[(object)property.Name] != null)
                        {
                            if ((string)property.Value != (string)jold[(object)property.Name])
                                jobject.Add(snakeCase, property.Value);
                        }
                        else
                            jobject.Add(snakeCase, property.Value);
                    }
                    else
                        jobject.Add(snakeCase, property.Value);
                }
            }
            return jobject;
        }

        protected static MPBase FillResourceWithResponseData<T>(
          T resource,
          MPAPIResponse response)
          where T : MPBase
        {
            if (response.JsonObjectResponse != null && response.JsonObjectResponse != null)
            {
                JObject jsonObjectResponse = response.JsonObjectResponse;
                resource = (T)MPBase.FillResource<T>((T)MPCoreUtils.GetResourceFromJson<T>(resource.GetType(), jsonObjectResponse), resource);
                resource._lastKnownJson = MPCoreUtils.GetJsonFromResource<T>(resource);
            }
            return (MPBase)resource;
        }

        protected static List<T> FillArrayWithResponseData<T>(Type clazz, MPAPIResponse response) where T : MPBase
        {
            List<T> objList = new List<T>();
            if (response.JsonObjectResponse != null)
            {
                JArray arrayFromJsonElement = MPCoreUtils.GetArrayFromJsonElement<T>(response.JsonObjectResponse);
                if (arrayFromJsonElement != null)
                {
                    for (int index = 0; index < arrayFromJsonElement.Count<JToken>(); ++index)
                    {
                        T resourceFromJson = (T)MPCoreUtils.GetResourceFromJson<T>(clazz, (JObject)arrayFromJsonElement[index]);
                        //resourceFromJson.DumpLog();
                        resourceFromJson._lastKnownJson = MPCoreUtils.GetJsonFromResource<T>(resourceFromJson);
                        objList.Add(resourceFromJson);
                    }
                }
            }
            else
            {
                JArray fromStringResponse = MPCoreUtils.GetJArrayFromStringResponse<T>(response.StringResponse);
                if (fromStringResponse != null)
                {
                    for (int index = 0; index < fromStringResponse.Count<JToken>(); ++index)
                    {
                        T resourceFromJson = (T)MPCoreUtils.GetResourceFromJson<T>(clazz, (JObject)fromStringResponse[index]);
                        resourceFromJson._lastKnownJson = MPCoreUtils.GetJsonFromResource<T>(resourceFromJson);
                        objList.Add(resourceFromJson);
                    }
                }
            }
            return objList;
        }

        private static MPBase FillResource<T>(T sourceResource, T destinationResource) where T : MPBase
        {
            foreach (FieldInfo field1 in destinationResource.GetType().GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
            {
                try
                {
                    FieldInfo field2 = sourceResource.GetType().GetField(field1.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
                    field1.SetValue((object)destinationResource, field2.GetValue((object)sourceResource));
                }
                catch (Exception ex)
                {
                    throw new MPException(ex.Message);
                }
            }
            return (MPBase)destinationResource;
        }

        public static MPAPIResponse CallAPI(
          HttpMethod httpMethod,
          string path,
          PayloadType payloadType,
          JObject payload,
          WebHeaderCollection colHeaders,
          bool useCache,
          int requestTimeout,
          int retries)
        {
            string key = httpMethod.ToString() + "_" + path;
            MPAPIResponse response = (MPAPIResponse)null;
            if (useCache)
            {
                response = MPCache.GetFromCache(key);
                if (response != null)
                    response.IsFromCache = true;
            }
            if (response == null)
            {
                response = new MPRESTClient().ExecuteRequest(httpMethod, path, payloadType, payload, colHeaders, requestTimeout, retries);
                if (useCache)
                    MPCache.AddToCache(key, response);
                else
                    MPCache.RemoveFromCache(key);
            }
            return response;
        }

        private static MethodInfo GetAnnotatedMethod(Type clazz, string methodName)
        {
            foreach (MethodInfo method in clazz.GetMethods())
            {
                if (method.Name == methodName && method.GetCustomAttributes(false).Length != 0)
                    return method;
            }
            throw new MPException("No annotated method found");
        }

        private static Dictionary<string, object> GetRestInformation(MethodInfo element)
        {
            if (element.GetCustomAttributes(false).Length == 0)
                throw new MPException("No rest method found");
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            foreach (Attribute customAttribute in element.GetCustomAttributes(false))
            {
                if (!(customAttribute is BaseEndpoint))
                    throw new MPException("Not supported method found");
                if (string.IsNullOrEmpty(((BaseEndpoint)customAttribute).Path))
                    throw new MPException(string.Format("Path not found for {0} method", (object)((BaseEndpoint)customAttribute).HttpMethod.ToString()));
                dictionary = new Dictionary<string, object>();
                dictionary.Add("method", (object)((BaseEndpoint)customAttribute).HttpMethod);
                dictionary.Add("path", (object)((BaseEndpoint)customAttribute).Path);
                dictionary.Add("instance", (object)element.ReturnType.Name);
                dictionary.Add("Header", (object)element.ReturnType.GUID);
                dictionary.Add("payloadType", (object)((BaseEndpoint)customAttribute).PayloadType);
                dictionary.Add("requestTimeout", (object)((BaseEndpoint)customAttribute).RequestTimeout);
                dictionary.Add("retries", (object)((BaseEndpoint)customAttribute).Retries);
            }
            return dictionary;
        }

        public static Type GetTypeFromStack()
        {
            string fullName = new StackTrace().GetFrame(2).GetMethod().DeclaringType.FullName;
            Type type1 = Type.GetType(fullName);
            if (type1 != null)
                return type1;
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                Type type2 = assembly.GetType(fullName);
                if (type2 != null)
                    return type2;
            }
            return (Type)null;
        }

        public static string ParsePath<T>(
          string path,
          Dictionary<string, string> mapParams,
          T resource, SDK sdk)
          where T : MPBase
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool flag = !path.Contains<char>(':') && mapParams != null && mapParams.Any<KeyValuePair<string, string>>();
            string pattern = ":([a-z0-9_]+)";
            foreach (Match match in Regex.Matches(path, pattern))
            {
                string text = match.Value.Replace(":", "");
                if (mapParams != null)
                {
                    foreach (KeyValuePair<string, string> mapParam in mapParams)
                    {
                        if (text == mapParam.Key)
                            path = path.Replace(match.Value, mapParam.Value);
                    }
                }
                JToken jtoken = JObject.FromObject((object)resource).GetValue(MPBase.ToPascalCase(text));
                if (jtoken != null)
                    path = path.Replace(match.Value, jtoken.ToString());
            }
            stringBuilder.Insert(0, sdk.BaseUrl);
            stringBuilder.Append(path);
            string str = (object)resource != null ? (!string.IsNullOrEmpty(resource.MarketplaceAccessToken) ? resource.MarketplaceAccessToken : sdk.GetAccessToken()) : sdk.GetAccessToken();
            Console.Out.WriteLine("STOP");
            if (!string.IsNullOrEmpty(str))
                stringBuilder.Append(string.Format("{0}{1}", (object)"?access_token=", (object)str));
            if (flag)
            {
                foreach (KeyValuePair<string, string> mapParam in mapParams)
                    stringBuilder.Append(string.Format("{0}{1}={2}", (object)"&", (object)mapParam.Key, (object)mapParam.Value));
            }
            return stringBuilder.ToString();
        }

        //public void DumpLog()
        //{
        //  JsonConvert.SerializeObject((object) this, Formatting.Indented);
        //  using (StringWriter stringWriter = new StringWriter())
        //  {
        //    Dumper.Dump((object) this, "Object Dumper", (TextWriter) stringWriter);
        //    Trace.WriteLine("Resource " + (object) stringWriter);
        //  }
        //}

        public static string GetUserToken(Type classType)
        {
            string str = "";
            UserToken customAttribute = (UserToken)Attribute.GetCustomAttribute((MemberInfo)classType, typeof(UserToken));
            if (customAttribute != null)
                str = customAttribute.GetUserToken();
            return str;
        }

        public JObject GetJsonSource()
        {
            if (this._lastApiResponse == null)
                return (JObject)null;
            return this._lastApiResponse.JsonObjectResponse;
        }

        public static bool Validate(object o)
        {
            PropertyInfo[] properties = o.GetType().GetProperties();
            Type attributeType = typeof(ValidationAttribute);
            MPBase.ValidationResult validationResult = new MPBase.ValidationResult();
            string message = "There are errors in the object you're trying to create. Review them to continue: ";
            foreach (PropertyInfo propertyInfo in properties)
            {
                foreach (object customAttribute in propertyInfo.GetCustomAttributes(attributeType, true))
                {
                    ValidationAttribute validationAttribute = (ValidationAttribute)customAttribute;
                    if (!validationAttribute.IsValid(propertyInfo.GetValue(o, BindingFlags.GetProperty, (Binder)null, (object[])null, (CultureInfo)null)))
                    {
                        string name = validationAttribute.GetType().Name;
                        if (!(name == "RangeAttribute"))
                        {
                            if (!(name == "RequiredAttribute"))
                            {
                                if (!(name == "RegularExpressionAttribute"))
                                {
                                    if (name == "DataTypeAttribute")
                                        validationResult.Errors.Add(new MPBase.ValidationError()
                                        {
                                            Message = MPBase.DataTypeError.Replace("#PROPERTY", propertyInfo.Name)
                                        });
                                }
                                else
                                    validationResult.Errors.Add(new MPBase.ValidationError()
                                    {
                                        Message = MPBase.RegularExpressionError.Replace("#PROPERTY", propertyInfo.Name).Replace("#REGEXPR", ((RegularExpressionAttribute)customAttribute).Pattern)
                                    });
                            }
                            else
                                validationResult.Errors.Add(new MPBase.ValidationError()
                                {
                                    Message = MPBase.RequiredError.Replace("#PROPERTY", propertyInfo.Name)
                                });
                        }
                        else
                            validationResult.Errors.Add(new MPBase.ValidationError()
                            {
                                Message = MPBase.RangeError.Replace("#PROPERTY", propertyInfo.Name)
                            });
                    }
                }
            }
            if (validationResult.Errors.Count<MPBase.ValidationError>() != 0)
            {
                foreach (MPBase.ValidationError error in validationResult.Errors)
                    message += error.Message;
                throw new Exception(message);
            }
            return true;
        }

        private static WebHeaderCollection GetStandardHeaders()
        {
            WebHeaderCollection headerCollection = new WebHeaderCollection();
            headerCollection.Add("x-product-id", "BC32BHVTRPP001U8NHL0");
            return headerCollection;
        }

        public static string ToPascalCase(string text)
        {
            return Regex.Replace(text, "(-|_)\\w{1}|^\\w", (MatchEvaluator)(match => match.Value.Replace("-", string.Empty).Replace("_", string.Empty).ToUpper()));
        }

        public static string ToSnakeCase(string text)
        {
            return Regex.Replace(text, "(?<=[a-z0-9])[A-Z\\s]", "_$0").ToLower();
        }

        public class ValidationResult
        {
            public List<MPBase.ValidationError> Errors = new List<MPBase.ValidationError>();
        }

        public class ValidationError
        {
            public int Code { get; set; }

            public string Message { get; set; }
        }
    }
}
