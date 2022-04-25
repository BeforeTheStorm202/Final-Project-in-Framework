using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;


namespace Azure_Translator_Service
{
    public partial class TranslatorAPI : Form
    {
        public TranslatorAPI()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com/";
        private static readonly string key1 = "";
        private static readonly string location = "southeastasia";
        /*
         * region = southeastasia
         * string url = "api-apc.cognitive.microsofttranslator.com"; 
        */

        private static readonly HttpClient client = new HttpClient();

        // Dictionary lookup
        private async void btnWord_Click(object sender, EventArgs e)
        {
            // Get the word that need to translate
            string wordToTranslate = input.Text.Trim();
            if (wordToTranslate.Split(' ').Length > 1)
            {
                MessageBox.Show("Please enter one word only to use this button, thank you!", "Attention");
                return;
            }

            // Clear previous output
            if (output.Text != String.Empty)
            {
                output.Text = output2.Text = view.Text = String.Empty;
            }

            /*
             * api-version = 3.0 is a must
             * from en/vi language
             * to vi/en language
             * $ - interpolated string
             */
            string fromlanguage = (lang1.Text == "English") ? "en" : "vi";
            string tolanguage = (lang2.Text == "English") ? "en" : "vi";
            string route = $"/dictionary/lookup?api-version=3.0&from={fromlanguage}&to={tolanguage}";

            // Get the post info and convert the object of that info into a JSON string
            object[] body = new object[] { new { Text = wordToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);

            // Build the http post request.
            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = HttpMethod.Post;
            // Combine endpoint and route to get the url that need to sent the post request 
            request.RequestUri = new Uri(endpoint + route);
            // Convert string into HTTP content
            request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
            // Add authentication headers
            request.Headers.Add("Ocp-Apim-Subscription-Key", key1); //passing the secret key
            request.Headers.Add("Ocp-Apim-Subscription-Region", location); //regional translator resource

            // Send the request and get response.
            HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
            // Read the json response as a string.
            string result = await response.Content.ReadAsStringAsync();
            // Trim to get the right json type
            result = result.Trim().TrimStart('[').TrimEnd(']');
            // Deserialized the json string to translationsreponse class object
            translationsreponse json = JsonConvert.DeserializeObject<translationsreponse>(result);
            // Display the translation result 
            foreach (var translation in json.translations)
            {
                output.Text += translation.displayTarget + " (" + translation.posTag + ")\n";
                foreach (var backtrans in translation.backTranslations)
                {
                    output2.Text += backtrans.displayText + "\n";
                    if (backtrans.normalizedText != translation.normalizedTarget)
                    {
                        Examples(backtrans.normalizedText, translation.normalizedTarget);
                    }
                }
            }
        }

        // Dictionary examples
        public async void Examples(string text, string trans)
        {
            string fromlanguage = (lang1.Text == "English") ? "en" : "vi";
            string tolanguage = (lang2.Text == "English") ? "en" : "vi";
            string route = $"/dictionary/examples?api-version=3.0&from={fromlanguage}&to={tolanguage}";

            object[] body = new object[] { new { Text = text, Translation = trans } };
            var requestbody = JsonConvert.SerializeObject(body);

            HttpRequestMessage requestMessage = new HttpRequestMessage();
            requestMessage.Method = HttpMethod.Post;
            requestMessage.Content = new StringContent(requestbody, Encoding.UTF8, "application/json");
            requestMessage.RequestUri = new Uri(endpoint + route);
            // Add authentication headers
            requestMessage.Headers.Add("Ocp-Apim-Subscription-Key", key1); //passing the secret key
            requestMessage.Headers.Add("Ocp-Apim-Subscription-Region", location); //regional translator resource

            //Send the request and get the response
            HttpResponseMessage responseMessage = await client.SendAsync(requestMessage).ConfigureAwait(false);
            //Read the response as json string
            string result = await responseMessage.Content.ReadAsStringAsync();

            result = result.Trim().TrimStart('[').TrimEnd(']');
            examplesresponse json = JsonConvert.DeserializeObject<examplesresponse>(result);

            // Display the examples in listview
            foreach (example ex in json.examples)
            {
                view.AppendText(ex.sourcePrefix + ex.sourceTerm + ex.sourceSuffix + "\n=> "
                    + ex.targetPrefix + ex.targetTerm + ex.targetSuffix + "\n");
            }
        }

        // Text translation and detection
        private async void btnText_Click(object sender, EventArgs e)
        {
            if (output.Text != String.Empty)
            {
                output.Text = output2.Text = view.Text = String.Empty;
            }

            string text2trans = input.Text;
            object[] body = new object[] { new { Text = text2trans } };
            var requestBody = JsonConvert.SerializeObject(body);

            string route = "";
            string tolanguage = (lang2.Text == "English") ? "en" : "vi";

            if (lang1.Text == "Detect language")
            {
                // Output languages are defined as parameters, input language detected.
                route = $"/translate?api-version=3.0&to={tolanguage}";
            }
            else
            {
                string fromlanguage = (lang1.Text == "English") ? "en" : "vi";
                route = $"/translate?api-version=3.0&from={fromlanguage}&to={tolanguage}";
            }

            using (var request = new HttpRequestMessage())
            {
                // Build the request.
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", key1);
                request.Headers.Add("Ocp-Apim-Subscription-Region", location);

                // Send the request and get response.
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                // Read response as a string.
                string result = await response.Content.ReadAsStringAsync();
                result = result.Trim().TrimStart('[').TrimEnd(']');
                translatetextresponse json = JsonConvert.DeserializeObject<translatetextresponse>(result);

                // Display the result
                foreach (translatetext tx in json.translations)
                {
                    output.Text += tx.text + "\n";
                }
            }
        }
        //End of this program
    }
}
