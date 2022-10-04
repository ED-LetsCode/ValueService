using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValueServiceLibrary;

namespace ValueServiceWinForm
{
    public partial class Main : Form
    {
        public Main(IValueService valueService)
        {
            InitializeComponent();
            _valueService = valueService;
            dataGridView1.DataSource = _valueService.PostFactors;
            ComboBoxPostFactor.DataSource = _valueService.PostFactors;
            ComboBoxPostFactor.DisplayMember = "Text";
            ComboBoxPostFactor.ValueMember = "TextShort";
        }

        private IValueService _valueService;
        private bool _withOutPostFactor = false;

        private void Convert_Click(object sender, EventArgs e)
        {
            try
            {
                if (_withOutPostFactor)
                {
                    Output.Text = _valueService.GetDecimal(WithPostfactor.Text).ToString();
                    return;
                }

                decimal.TryParse(WithoutPostfactor.Text, out decimal result);
                Output.Text = _valueService.GetDisplayValue(result, (int)Precision.Value, ComboBoxPostFactor.SelectedValue.ToString()!);
            }
            catch (Exception)
            {
                MessageBox.Show("Input was not in correct format");
            }
        }

        private void WithoutPostfactor_Click(object sender, EventArgs e)
        {
            _withOutPostFactor = false;
            WithPostfactor.Clear();
            Output.Clear();
        }

        private void WithPostfactor_Click(object sender, EventArgs e)
        {
            _withOutPostFactor = true;
            WithoutPostfactor.Clear();
            ComboBoxPostFactor.SelectedIndex = 0;
            Precision.Value = 0;
            Output.Clear();
        }

        private void WithoutPostfactor_TextChanged(object sender, EventArgs e)
        {
            WithoutPostfactor.Text = Regex.Replace(WithoutPostfactor.Text, "[^0-9.]", "");
            WithoutPostfactor.SelectionStart = WithoutPostfactor.Text.Length;
        }
    }
}
