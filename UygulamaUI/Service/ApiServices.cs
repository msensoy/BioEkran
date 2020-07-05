using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using UygulamaUI.Constant;
using UygulamaUI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UygulamaUI.Services.Data
{
    public class ApiServices 
    {
        public async Task<string> RegisterUserAsync(
            string email, string phoneNumber, string password, string confirmPassword)
        {
            var client = new HttpClient();

            var model = new RegisterBindingModel
            {
                Email = email,
                PhoneNumber = phoneNumber,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            var json = JsonConvert.SerializeObject(model);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(
                Constants.BaseApiAddress + "api/Account/Register", httpContent);

            if (response.IsSuccessStatusCode)
            {
                return await LoginAsync(email, password);
            }

            return "";
        }

        public async Task<string> LoginAsync(string userName, string password)
        {
            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", userName),
                new KeyValuePair<string, string>("password", password),
                new KeyValuePair<string, string>("grant_type", "password")
            };

            var request = new HttpRequestMessage(
                HttpMethod.Post, Constants.BaseApiAddress + "Token");

            request.Content = new FormUrlEncodedContent(keyValues);

            var client = new HttpClient();
            var response = await client.SendAsync(request);

            var content = await response.Content.ReadAsStringAsync();

            JObject jwtDynamic = JsonConvert.DeserializeObject<JObject>(content);
            var accessTokenExpiration = jwtDynamic.Value<DateTime>(".expires");
            var accessToken = jwtDynamic.Value<string>("access_token");
            return accessToken;
        }

        public async Task<List<Device>> GetDevicesAsync(string accessToken)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer", accessToken);

            var json = await client.GetStringAsync(Constants.BaseApiAddress + "api/Device");

            var devices = JsonConvert.DeserializeObject<List<Device>>(json);

            return devices;
        }

        public async Task<List<Device>> GetDevicesForCurrentUserAsync(string accessToken)
        {
            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    "Bearer", accessToken);

                var json = await client.GetStringAsync(Constants.BaseApiAddress + "api/Device/ForCurrentUser");

                var devices = JsonConvert.DeserializeObject<List<Device>>(json);

                return devices;
            }
            catch
            {
                return null;
            }
            
        }

        public async Task PostDeviceAsync(Device device, string accessToken)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var json = JsonConvert.SerializeObject(device);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(Constants.BaseApiAddress + "api/Device", content);
        }

        public async Task PutDeviceAsync(Device device, string accessToken)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var json = JsonConvert.SerializeObject(device);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PutAsync(
                Constants.BaseApiAddress + "api/Device/" + device.Id, content);
        }

        public async Task DeleteDeviceAsync(int deviceId, string accessToken)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var response = await client.DeleteAsync(
                Constants.BaseApiAddress + "api/Device/" + deviceId);
        }

        public async Task<List<Device>> SearchDevicesAsync(string keyword, string accessToken)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer", accessToken);

            var json = await client.GetStringAsync(
                Constants.BaseApiAddress + "api/Device/Search/" + keyword);

            var devices = JsonConvert.DeserializeObject<List<Device>>(json);

            return devices;
        }

        public async Task<bool> AddUserToDeviceAsync(int deviceId, string email, string accessToken)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var json = JsonConvert.SerializeObject(new
            {
                DeviceId = deviceId,
                UserEmail = email,
            });
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(Constants.BaseApiAddress + "api/Device/Add", content);
            return response.StatusCode == System.Net.HttpStatusCode.OK;
        }

        public async Task<bool> AddUserToDeviceAsync(int deviceId, string accessToken)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var json = JsonConvert.SerializeObject(new 
            {
                DeviceId = deviceId,
                Email = ""
            });
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync(Constants.BaseApiAddress + "api/Device/Add", content);
            return  response.StatusCode == System.Net.HttpStatusCode.OK || 
                    response.StatusCode == System.Net.HttpStatusCode.Conflict;
        }


        public async Task<string> GetCommandAsync(string accessToken, int deviceId)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer", accessToken);

            var json = await client.GetStringAsync(
                Constants.BaseApiAddress + "api/Command/Last/" + deviceId);

            var command = JsonConvert.DeserializeObject<CommandModel>(json);

            return command.Value;
        }

        public async Task<Device> GetDevice(string accessToken, int deviceId)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Bearer", accessToken);

            var json = await client.GetStringAsync(Constants.BaseApiAddress + $"api/Device/{deviceId}");

            var model = JsonConvert.DeserializeObject<Device>(json);

            return model;
        }
    }
}
