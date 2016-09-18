using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace MyJson
{
  public partial class Form1 : Form
  {
    List<clPerson> lstPerson = new List<clPerson>();
    string destPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "file.txt");

    public Form1()
    {
      InitializeComponent();
      test();
    }

    private void test()
    {
      clPerson product = new clPerson();
      product.Name = "Apple";
      product.ExpireDate = new DateTime(2008, 12, 28);
      product.Price = 3.99;
      product.Size = new string[] { "Small", "Medium", "Large" };
      lstPerson.Add(product);
      DoSerialize();

    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.lstPerson = JsonConvert.DeserializeObject<List<clPerson>>(File.ReadAllText(destPath));
      clPerson a = new clPerson();
      a.Name = "asf";,
      lstPerson.Add(a);
      DoSerialize();
    }

    private void DoSerialize()
    {
      string output = JsonConvert.SerializeObject(lstPerson);
      System.IO.File.WriteAllText(destPath, output);
    }

  }
}
