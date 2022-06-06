using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ProjectShip.model;

namespace ProjectShip.UI
{
    public partial class FormMain : Form
    {
        private Assembly modelInfo;
        private object obj;
        public FormMain()
        {
            InitializeComponent();
            obj = new object();
            // загружаем нужную сборку
            modelInfo = Assembly.Load("NewShipModel"); //projectShip

            // получаем всех наследников абстрактного класса
            IEnumerable<Type> types = modelInfo.GetTypes().Where
                (type => type.IsSubclassOf(typeof(MilitaryShip)));

            if (types.Count() > 0)
            {
                // выгружаем данные в comboBox
                var comboSource = new Dictionary<Type, string>();
                foreach (Type t in types)
                {
                    comboSource.Add(t, t.Name);
                }
                comboBoxClass.DataSource = new BindingSource(comboSource, null);
                comboBoxClass.DisplayMember = "Value";
                comboBoxClass.ValueMember = "Key";
            }
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            // получаем выбранный класс
            Type selectedType = ((KeyValuePair<Type, string>)comboBoxClass.SelectedItem).Key;
            // создаем объект выбранного класса
            if (selectedType != null)
            {
                obj = Activator.CreateInstance(selectedType);
                // отображаем объект в textBox
                textBoxObjectInfo.Text = obj?.ToString();
            }
            // получаем список методов выбранного класса
            MethodInfo[] objectMethods = selectedType.GetMethods();
            if (objectMethods.Length > 0)
            {
                // выгружаем данные в comboBox
                var comboSource = new Dictionary<MethodInfo, string>();
                foreach (MethodInfo mInfo in objectMethods)
                {
                    comboSource.Add(mInfo, mInfo.Name);
                }
                comboBoxMethod.DataSource = new BindingSource(comboSource, null);
                comboBoxMethod.DisplayMember = "Value";
                comboBoxMethod.ValueMember = "Key";
            }
        }

        private void buttonNewObject_Click(object sender, EventArgs e)
        {
            // создаем новый объект выбранного класса
            Type selectedType = ((KeyValuePair<Type, string>)comboBoxClass.SelectedItem).Key;
            if (selectedType != null)
            {
                obj = Activator.CreateInstance(selectedType);
                textBoxObjectInfo.Text = obj?.ToString();
            }
        }

        // активация выбранного метода
        private void buttonActivateMethod_Click(object sender, EventArgs e)
        {
            // получаем выбранный метод
            MethodInfo selectedMethod = ((KeyValuePair<MethodInfo, string>)comboBoxMethod.SelectedItem).Key;
            // определяем список параметров метода
            List<object> methodParams = new List<object>();
            bool paramsOk = true;
            ParameterInfo[] parameters = selectedMethod.GetParameters();
            for(int i = 0; (i < parameters.Length) && paramsOk; i++)
            {
                // если параметр типа int, то просим задать его во всплывающем окне
                // если при заполнении параметров произойдет отмена, или встретится параметр другого типа,
                // то метод вызываться не будет
                if (parameters[i].ParameterType.Equals(typeof(int)))
                {
                    FormInputNum formInputNum = new FormInputNum(parameters[i].Name);
                    if (formInputNum.ShowDialog() == DialogResult.OK)
                    {
                        methodParams.Add(formInputNum.Value);
                    }
                    else
                    {
                        paramsOk = false;
                    }
                }
                else
                {
                    paramsOk = false;
                }
            }
            if (paramsOk)
            {
                object res = selectedMethod.Invoke(obj, methodParams.ToArray());
                textBoxObjectInfo.Text = obj?.ToString();
                if (res != null)
                    MessageBox.Show("Метод вернул значение " + res, "Результат");
            }
            else
            {
                MessageBox.Show("Невозможно выполнить метод!", "Ошибка");
            }
        }
    }
}
