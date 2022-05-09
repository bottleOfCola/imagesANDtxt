using RestSharp;
using Newtonsoft.Json;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace imagesANDtxt
{
    public partial class Form1 : Form
    {
        private string _path;
        private bool _IU;
        private int _lang = -1;
        private string _url = "https://api.ocr.space/parse/image";
        private string _key;

        string[] _apiCountries = {
            "ara",
            "bul",
            "chs",
            "cht",
            "hrv",
            "cze",
            "dan",
            "dut",
            "eng",
            "fin",
            "fre",
            "ger",
            "gre",
            "hun",
            "kor",
            "ita",
            "jpn",
            "pol",
            "por",
            "rus",
            "slv",
            "spa",
            "swe",
            "tur"
            };
        string[] _clientCountries = {
            "��������",
            "����������",
            "���������(�������)",
            "���������(������������)",
            "����������",
            "�������",
            "�������",
            "�����������",
            "����������",
            "�������",
            "�����������",
            "��������",
            "���������",
            "����������",
            "���������",
            "�����������",
            "��������",
            "��������",
            "�������������",
            "�������",
            "����������",
            "���������",
            "��������",
            "��������",
            };
        public Form1()
        {
            InitializeComponent();

            openFile.Click += OpenFile;
            convert.Click += Convertation;
            langs.SelectedIndexChanged += SelectLang;
            langs.Items.AddRange(_clientCountries);

        }

        private void SelectLang(object? sender, EventArgs e)
        {
            _lang = langs.SelectedIndex;
        }

        private void Convertation(object? sender, EventArgs e)
        {
            _key = apikey.Text;
            string err = "�� �� ";
            if (apikey.Text == "")
                err += "������� ��� apikey ";
            if (_path is null || _path == "")
            {
                if (_key == "")
                    err += "� �� ";
                err += "������� ����";
            }
            if(err.Length > 6)
            {
                MessageBox.Show(err);
                return;
            }
            if (_path is not null)
            {
                var client = new RestClient(_url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("apikey", _key);
                request.AlwaysMultipartFormData = true;
                request.AddFile("file", _path);
                request.AddParameter("url", _path);
                if(_lang >= 0)
                    request.AddParameter("language", _apiCountries[_lang]);
                IRestResponse response = client.Execute(request);
                string apiErr = "\"The API key is invalid\"";
                if (response.Content == apiErr)
                {
                    MessageBox.Show("�� ����� ������������ api key");
                    return;
                }
                JObject j = JObject.Parse(response.Content);
                JToken item = j.SelectToken(".ParsedResults")[0].SelectToken(".ParsedText");

                textBox.Text = item.ToString();
            }
        }

        private void OpenFile(object? sender, EventArgs e)
        {
            if (web.Checked == false && img.Checked == false)
                MessageBox.Show("�� �� ������� ������");
            if(path.Text.Length != 0 || web.Checked )
            {
                if(File.Exists(path.Text))
                {
                    _path = path.Text;
                    image.Image = Image.FromFile(_path);
                    _IU = true;
                }
                else
                {
                    if(Uri.IsWellFormedUriString(path.Text, UriKind.RelativeOrAbsolute))
                    {
                        _path = path.Text;
                        string nameOfPic = _path.Split('/').Last();
                        string dir = AppDomain.CurrentDomain.BaseDirectory;
                        _IU = false;
                        if (File.Exists(dir + "\\" + nameOfPic))
                            return;
                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(_path, AppDomain.CurrentDomain.BaseDirectory + nameOfPic);
                        }
                    }
                }
            }
            else
            {
                if (img.Checked == false || openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                _path = openFileDialog1.FileName;
                path.Text = _path;
                image.Image = Image.FromFile(_path);
                _IU = true;
            }
        }
    }
}