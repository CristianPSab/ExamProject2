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
        private RadioButton rdbTxt;
        private RadioButton rdbXml;
        private RadioButton rdbJson;
        private Label label1;

        public Form1 () 
        {
            InitializeComponent();

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
            this.rdbTxt = new System.Windows.Forms.RadioButton();
            this.rdbXml = new System.Windows.Forms.RadioButton();
            this.rdbJson = new System.Windows.Forms.RadioButton();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(164, 69);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nombre:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(164, 139);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(77, 20);
            this.lbSurname.TabIndex = 1;
            this.lbSurname.Text = "Apellidos:";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(164, 208);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(170, 20);
            this.lbBirthday.TabIndex = 2;
            this.lbBirthday.Text = "Fecha de cumpleaños:";
            // 
            // lbSave
            // 
            this.lbSave.AutoSize = true;
            this.lbSave.Location = new System.Drawing.Point(74, 276);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(153, 20);
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
            // rdbTxt
            // 
            this.rdbTxt.AutoSize = true;
            this.rdbTxt.Checked = true;
            this.rdbTxt.Location = new System.Drawing.Point(428, 274);
            this.rdbTxt.Name = "rdbTxt";
            this.rdbTxt.Size = new System.Drawing.Size(63, 24);
            this.rdbTxt.TabIndex = 10;
            this.rdbTxt.TabStop = true;
            this.rdbTxt.Text = "TXT";
            this.rdbTxt.UseVisualStyleBackColor = true;
            // 
            // rdbXml
            // 
            this.rdbXml.AutoSize = true;
            this.rdbXml.Location = new System.Drawing.Point(600, 276);
            this.rdbXml.Name = "rdbXml";
            this.rdbXml.Size = new System.Drawing.Size(67, 24);
            this.rdbXml.TabIndex = 11;
            this.rdbXml.Text = "XML";
            this.rdbXml.UseVisualStyleBackColor = true;
            // 
            // rdbJson
            // 
            this.rdbJson.AutoSize = true;
            this.rdbJson.Location = new System.Drawing.Point(734, 274);
            this.rdbJson.Name = "rdbJson";
            this.rdbJson.Size = new System.Drawing.Size(76, 24);
            this.rdbJson.TabIndex = 12;
            this.rdbJson.Text = "JSON";
            this.rdbJson.UseVisualStyleBackColor = true;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(428, 208);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(391, 26);
            this.dtBirthday.TabIndex = 13;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1073, 384);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.rdbJson);
            this.Controls.Add(this.rdbXml);
            this.Controls.Add(this.rdbTxt);
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

        private void RadioButton()
        {
          
           

            if (this.rdbTxt.Checked==false)
            {
                this.rdbTxt.Checked.Equals(true);
            }

            if (this.rdbXml.Checked==false)
            {
                this.rdbXml.Checked.Equals(true);
            }

            if (this.rdbJson.Checked==false)
            {
                this.rdbJson.Checked.Equals(true);
            }
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           try
           {
              //  RadioButton();


                var name = tbName.Text;
                var surname = tbSurname.Text;
                var birthday = dtBirthday;

                var studentBR = new StudentBR();
                var student = new StudentModel(name, surname, birthday);
                studentBR.SaveToTXT(student);
            

            }
            catch (Exception)
           {
                
                MessageBox.Show( "No se puede guardar");
           }

            
        }
    }
}