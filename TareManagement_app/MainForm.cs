using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareManagement_app
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tareManagementDataSet.NMShipProdSelContCustSeq". При необходимости она может быть перемещена или удалена.
            this.nMShipProdSelContCustSeqTableAdapter.Fill(this.tareManagementDataSet.NMShipProdSelContCustSeq);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tareManagementDataSet.Item". При необходимости она может быть перемещена или удалена.
            this.itemTableAdapter.Fill(this.tareManagementDataSet.Item);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> WeightList = new List<string>();
            List<string> DepthList = new List<string>();
            List<string> HeightList = new List<string>();
            List<string> WidthList = new List<string>();

            // Перебираем строки в DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Получаем значение чекбокса в текущей строке
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["CheckBoxColumn"] as DataGridViewCheckBoxCell;
                bool isChecked = Convert.ToBoolean(checkBoxCell.Value);

                // Если чекбокс отмечен, добавляем соответствующее поле в список
                if (isChecked)
                {


                    string weight = row.Cells[3].Value.ToString();
                    string depth = row.Cells[4].Value.ToString();
                    string height = row.Cells[5].Value.ToString();
                    string wight = row.Cells[6].Value.ToString();
                    WeightList.Add(weight);
                    DepthList.Add(depth);
                    HeightList.Add(height);
                    WidthList.Add(wight);
                }
            }

            // Заданные данные о размерах упаковки и ее весе, временные
            double maxLength = 100; // Длина упаковки
            double maxWidth = 100;   // Ширина упаковки
            double maxHeight = 100;  // Высота упаковки
            double maxWeight = 100; // Максимальный вес упаковки

            // Создание списка изделий на основе данных
            List<Item> items = new List<Item>();
            for (int i = 0; i < WeightList.Count; i++)
            {
                items.Add(new Item
                {
                    Weight = Convert.ToDouble(WeightList[i]),
                    Depth = Convert.ToDouble(DepthList[i]),
                    Height = Convert.ToDouble(HeightList[i]),
                    Width = Convert.ToDouble(WidthList[i])
                });
            }

            int totalPackages = PackItems(items, maxLength, maxWidth, maxHeight, maxWeight);
            MessageBox.Show("Общее количество упаковок для всех товаров: " + totalPackages);
        }

        static int PackItems(List<Item> items, double maxLength, double maxWidth, double maxHeight, double maxWeight)
        {
            items = items.OrderByDescending(i => i.VolumeWeightRatio).ToList(); // сортировка по объему к весу

            int totalPackages = 0;
            double currentWeight = 0;
            double currentDepth = 0;
            double currentHeight = 0;
            double currentWidth = 0;

            foreach (var item in items)
            {
                if (currentWeight + item.Weight <= maxWeight &&
                    currentDepth + item.Depth <= maxLength &&
                    currentHeight + item.Height <= maxHeight &&
                    currentWidth + item.Width <= maxWidth)
                {
                    currentWeight += item.Weight;
                    currentDepth += item.Depth;
                    currentHeight += item.Height;
                    currentWidth += item.Width;
                }
                else
                {
                    totalPackages++;
                    currentWeight = item.Weight;
                    currentDepth = item.Depth;
                    currentHeight = item.Height;
                    currentWidth = item.Width;
                }
            }

            if (currentWeight > 0 || currentDepth > 0 || currentHeight > 0 || currentWidth > 0)
            {
                totalPackages++;
            }

            return totalPackages;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Обработка выбора грузополучателя и отправка данных в NMShipProdSelCont_UnitCont
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Depth { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double VolumeWeightRatio => (Depth * Height * Width) / Weight;
    }
}
