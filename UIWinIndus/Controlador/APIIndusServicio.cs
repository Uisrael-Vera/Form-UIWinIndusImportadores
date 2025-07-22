using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace UIWinIndus.Controlador
{
    public class APIIndusServicio
    {
        //comunicar con API
        private readonly HttpClient _httpClient;
        //direccion Base de API
        private string _baseUrl;

        public APIIndusServicio(string baseUrl)
        {
            _baseUrl = baseUrl.TrimEnd('/');
            _httpClient = new HttpClient();
        }

        //Metodo Generico para Select*
        public async Task<T> GetAsync<T>(string endpoint)
        {
            var ruta = await _httpClient.GetAsync($"{_baseUrl}/{endpoint}");
            ruta.EnsureSuccessStatusCode();

            var contenido = await ruta.Content.ReadAsStringAsync(); //Lee resultado
            return JsonConvert.DeserializeObject<T>(contenido);

        }

        //Metodo Generico para Insertar

        public async Task CrearEntidad<T>(T entidad, string endpoint, string nombreEntidad)
        {
            var json = JsonConvert.SerializeObject(entidad);//Convierte en Json al DTOde aqui
            var contenido = new StringContent(json, Encoding.UTF8, "application/json");
            var respuesta = await _httpClient.PostAsync($"{_baseUrl}/{endpoint}", contenido);
            if (!respuesta.IsSuccessStatusCode)
            {
                var errorEncontrado = await respuesta.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Error: Al insertar{nombreEntidad}.Detalles:{errorEncontrado}");
            }
        }


        //Metodo para Verificar user
        public async Task<T> PostAsync<T>(string endpoint, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{_baseUrl}/{endpoint}", content);

            if (!response.IsSuccessStatusCode)
                return default;

            var responseData = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseData);
        }


        public async Task EditarEntidad<T>(T entidad, string endpoint, string nombreEntidad)
        {
            var json = JsonConvert.SerializeObject(entidad);//Convierte en Json al DTOde aqui
            var contenido = new StringContent(json, Encoding.UTF8, "application/json");
            var respuesta = await _httpClient.PutAsync($"{_baseUrl}/{endpoint}", contenido);
            if (!respuesta.IsSuccessStatusCode)
            {
                var errorEncontrado = await respuesta.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Error: Al actualizar{nombreEntidad}.Detalles:{errorEncontrado}");
            }

        }

        public async Task<byte[]> GetBytesAsync(string endpoint)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/{endpoint}");

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadAsByteArrayAsync();
        }


    }
}
        
