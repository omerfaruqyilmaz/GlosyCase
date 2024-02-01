using CaseAPI.Core.Result;
using CaseAPI.Entities.Dto.Product.Request;
using CaseAPI.Entities.Entity;
using Newtonsoft.Json;

namespace CaseForm
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;
        private const string BaseApiUrl = "https://localhost:7137/api/Product/";

        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private async void btn_list_Click(object sender, EventArgs e)
        {

            HttpResponseMessage response = await _httpClient.GetAsync(BaseApiUrl + "products");

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                DataResult dataResult = JsonConvert.DeserializeObject<DataResult>(responseData);

                if (!dataResult.IsError)
                {
                    listBox1.Items.Clear();

                    var productList = JsonConvert.DeserializeObject<List<Product>>(dataResult.Data.ToString());

                    foreach (var product in productList)
                    {
                        listBox1.Items.Add($"{product.Id} - {product.CategoryName} - {product.Title} - {product.Price}");
                    }

                }

                else
                {
                    MessageBox.Show("Error in API response: " + string.Join(", ", dataResult.ErrorMessageList));
                }
            }

            else
            {
                MessageBox.Show("Error retrieving products: " + response.ReasonPhrase);
            }
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            
            AddProductRequest request = new AddProductRequest
            {
                CategoryName = txt_category.Text,
                Title = txt_title.Text,
                Price = decimal.Parse(txt_price.Text)
            };

            string jsonRequest = JsonConvert.SerializeObject(request);
            HttpContent content = new StringContent(jsonRequest, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(BaseApiUrl + "add-product", content);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                DataResult dataResult = JsonConvert.DeserializeObject<DataResult>(responseData);

                if (!dataResult.IsError)
                {
                    MessageBox.Show("Product added successfully!");
                    btn_list_Click(sender, e);
                }

                else
                {
                    MessageBox.Show("Error in API response: " + string.Join(", ", dataResult.ErrorMessageList));
                }

            }

            else
            {
                MessageBox.Show("Error adding product: " + response.ReasonPhrase);
            }

        }

        private async void btn_update_Click(object sender, EventArgs e)
        {

            UpdateProductRequest request = new UpdateProductRequest
            {
                Id = int.Parse(txt_id.Text),
                CategoryName = txt_category.Text,
                Title = txt_title.Text,
                Price = decimal.Parse(txt_price.Text) 
            };

            string jsonRequest = JsonConvert.SerializeObject(request);
            HttpContent content = new StringContent(jsonRequest, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PutAsync(BaseApiUrl + "update-product", content);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                DataResult dataResult = JsonConvert.DeserializeObject<DataResult>(responseData);

                if (!dataResult.IsError)
                {
                    MessageBox.Show("Product updated successfully!");
                    btn_list_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error in API response: " + string.Join(", ", dataResult.ErrorMessageList));
                }
            }

            else
            {
                MessageBox.Show("Error updating product: " + response.ReasonPhrase);
            }
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(txt_id.Text); 
            HttpResponseMessage response = await _httpClient.DeleteAsync(BaseApiUrl + $"delete-product?id={productId}");

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                DataResult dataResult = JsonConvert.DeserializeObject<DataResult>(responseData);

                if (!dataResult.IsError)
                {
                    MessageBox.Show("Product deleted successfully!");
                    btn_list_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error in API response: " + string.Join(", ", dataResult.ErrorMessageList));
                }
            }

            else
            {
                MessageBox.Show("Error deleting product: " + response.ReasonPhrase);
            }

        }
    }
}
