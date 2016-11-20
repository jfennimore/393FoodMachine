using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _393_Food_Machine.Models
{
    class APICalls
    {
        public static String baseUrl = "http://food-machine-api.herokuapp.com";

        private static String makeCall(HttpWebRequest request)
        {
            StreamReader response = new StreamReader(request.GetResponse().GetResponseStream());
            StringBuilder fullResponse = new StringBuilder();
            String responseLine = "";
            while (responseLine != null)
            {
                responseLine = response.ReadLine();
                fullResponse.Append(responseLine);
            }
            return fullResponse.ToString();
        }

        public static String getCall(String urlExtension)
        {
            String fullUrl = baseUrl + "//" + urlExtension;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullUrl);
            request.ContentType = "application/json";
            request.Accept = "*/*";
            request.Method = "GET";
            return makeCall(request);
        }

        public static String postCall(String urlExtension, Editable obj)
        {
            String fullUrl = baseUrl + "//" + urlExtension;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullUrl);
            request.ContentType = "application/json";
            request.Accept = "*/*";
            request.Method = "POST";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string data = obj.ToString();

                streamWriter.Write(data);
            }
            return makeCall(request);
        }

        public static String putCall(Editable obj)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(obj.uri);
            request.ContentType = "application/json";
            request.Accept = "*/*";
            request.Method = "PUT";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string data = obj.ToString();

                streamWriter.Write(data);
            }
            return makeCall(request);
        }

        public static String deleteCall(Editable obj)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(obj.uri);
            request.ContentType = "application/json";
            request.Accept = "*/*";
            request.Method = "DELETE";
            return makeCall(request);
        }

        public static String getAllIngredients()
        {
            return getCall("ingredients");
        }

        public static String postNewIngredient(Ingredient ingredient)
        {
            return postCall("ingredients", ingredient);
        }

        public static String getIngredientByName(String ingrName)
        {
            return getCall("ingredients//" + ingrName);
        }

        public static String getAllRecipes()
        {
            return getCall("recipes");
        }

        public static String postNewRecipe(Recipe recipe)
        {
            return postCall("recipes", recipe);
        }

        public static string postNewStore(Store store)
        {
            return postCall("stores", store);
        }

        public static string postNewGrocList(GroceryList groceryList)
        {
            return postCall("grocery lists",groceryList);
        }

        //The Json Deserializer is expecting the value portion of what the API returns, which wraps everything.
        //I.e., the serializer is looking for a list of ingredients, and the API returns "{ "ingredients" : [the list] }"
        //So this method extracts what you want
        public static T extractFromJson<T>(String json, String key)
        {
            try
            {
                JObject outerLayer = JObject.Parse(json);
                T confirmed = JsonConvert.DeserializeObject<T>(outerLayer.GetValue(key).ToString());
                return confirmed;
            }
            catch (Exception e)
            {
                //There must have been an issue deserializing the result of the request.
                System.Windows.Forms.MessageBox.Show(String.Format("There was a problem extracting {0} from {1}", key, json));
                return default(T);
            }
        }
    }
}
