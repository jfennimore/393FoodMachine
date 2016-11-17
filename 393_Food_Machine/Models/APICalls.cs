using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

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

        public static String getIndivCall(String urlExtension, int id)
        {
            String fullExtension = urlExtension + "//" + id;
            return getCall(fullExtension);
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

        public static String putCall(String urlExtension, Editable obj)
        {
            String fullUrl = baseUrl + "//" + urlExtension;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullUrl);
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

        public static String deleteCall(String urlExtension, Editable obj)
        {
            String fullUrl = baseUrl + "//" + urlExtension;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(fullUrl);
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

        public static String updateIngredient(Ingredient ingredient)
        {
            return putCall("ingredients", ingredient);
        }

        public static String deleteIngredient(Ingredient ingredient)
        {
            return deleteCall("ingredients", ingredient);
        }

        public static String getAllRecipes()
        {
            return getCall("recipes");
        }

        public static String getRecipeById(int id)
        {
            return getIndivCall("recipes", id);
        }

        public static String postNewRecipe(Recipe recipe)
        {
            return postCall("recipes", recipe);
        }

        public static String updateRecipe(Recipe recipe)
        {
            return putCall("recipes", recipe);
        }

        public static String deleteRecipe(Recipe recipe)
        {
            return deleteCall("recipes", recipe);
        }
    }
}
