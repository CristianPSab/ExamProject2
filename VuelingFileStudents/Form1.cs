using System;
using System.Windows.Forms;
using VuelingFileStudents.Business.Rules;
using VuelingFileStudents.Transversal.Utilities.Models;

namespace VuelingFileStudents
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private Label lbName;
        private Label lbSurname;
        private Label lbBirthday;
        private Label lbSave;
        private Button btnSave;
        private TextBox tbName;
        private TextBox tbSurname;
        

        public Form1 () 
        {
            InitializeComponent();
            InitializeComboBox();

        }

        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbSave = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(164, 69);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(93, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nombre:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(164, 139);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(106, 25);
            this.lbSurname.TabIndex = 1;
            this.lbSurname.Text = "Apellidos:";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(164, 208);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(230, 25);
            this.lbBirthday.TabIndex = 2;
            this.lbBirthday.Text = "Fecha de cumpleaños:";
            // 
            // lbSave
            // 
            this.lbSave.AutoSize = true;
            this.lbSave.Location = new System.Drawing.Point(74, 276);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(204, 25);
            this.lbSave.TabIndex = 3;
            this.lbSave.Text = "Guardar en formato:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(897, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(428, 47);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(391, 42);
            this.tbName.TabIndex = 7;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(428, 117);
            this.tbSurname.Multiline = true;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(391, 42);
            this.tbSurname.TabIndex = 9;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(428, 208);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(391, 31);
            this.dtBirthday.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(428, 273);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(391, 33);
            this.comboBox1.TabIndex = 14;
           
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1073, 384);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbSave);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Name = "Form1";
            this.Text = "Students Vueling University";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeComboBox()
        {
            var txt = ".txt";
            var xml = ".xml";
            var json = ".json";
            this.comboBox1.Items.Add(txt);
            this.comboBox1.Items.Add(xml);
            this.comboBox1.Items.Add(json);


        }





        private void BtnSave_Click(object sender, EventArgs e)
        {
         
                var studentb = new StudentModel();

                var name = tbName.Text;
                var surname = tbSurname.Text;
                var birthday = dtBirthday.Value;


                var studentBR = new StudentBR();
                var student = new StudentModel(name, surname, birthday);

                try
                {
                    object selectedFormat = comboBox1.SelectedItem;

                    if (selectedFormat != null)
                    {


                        studentBR.ProcessStudentData(tbName.Text, tbSurname.Text, dtBirthday.Value, selectedFormat.ToString());
                    }
                    else
                    {
                        MessageBox.Show("El formato está mal");
                    }

                    MessageBox.Show("Documento generado con éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "Error al generar el documento");
                    throw;
                }


            }

       
    }
}