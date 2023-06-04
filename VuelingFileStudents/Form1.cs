using System.Windows.Forms;

namespace VuelingFileStudents
{
    internal class Form1 : Form
    {
        private Label lbName;
        private Label lbSurname;
        private Label lbBirthday;
        private TextBox tbName;
        private TextBox tbBirthday;
        private Label lbNewStudent;
        private Label lbSaveFormat;
        private Button btnTxt;
        private Button btnXml;
        private Button btnJsn;
        private TextBox tbSurname;

        private void InitializeComponent()
        {
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lbNewStudent = new System.Windows.Forms.Label();
            this.lbSaveFormat = new System.Windows.Forms.Label();
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnJsn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(183, 61);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nombre:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Location = new System.Drawing.Point(187, 148);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(77, 20);
            this.lbSurname.TabIndex = 1;
            this.lbSurname.Text = "Apellidos:";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Location = new System.Drawing.Point(187, 231);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(161, 20);
            this.lbBirthday.TabIndex = 2;
            this.lbBirthday.Text = "Fecha de nacimiento:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(446, 55);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(335, 43);
            this.tbName.TabIndex = 3;
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(446, 228);
            this.tbBirthday.Multiline = true;
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(335, 47);
            this.tbBirthday.TabIndex = 4;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(446, 142);
            this.tbSurname.Multiline = true;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(335, 50);
            this.tbSurname.TabIndex = 5;
            // 
            // lbNewStudent
            // 
            this.lbNewStudent.AutoSize = true;
            this.lbNewStudent.Location = new System.Drawing.Point(42, 22);
            this.lbNewStudent.Name = "lbNewStudent";
            this.lbNewStudent.Size = new System.Drawing.Size(138, 20);
            this.lbNewStudent.TabIndex = 6;
            this.lbNewStudent.Text = "Añadir estudiante:";
            // 
            // lbSaveFormat
            // 
            this.lbSaveFormat.AutoSize = true;
            this.lbSaveFormat.Location = new System.Drawing.Point(122, 346);
            this.lbSaveFormat.Name = "lbSaveFormat";
            this.lbSaveFormat.Size = new System.Drawing.Size(153, 20);
            this.lbSaveFormat.TabIndex = 7;
            this.lbSaveFormat.Text = "Guardar en formato:";
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(389, 361);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(111, 39);
            this.btnTxt.TabIndex = 8;
            this.btnTxt.Text = "TXT";
            this.btnTxt.UseVisualStyleBackColor = true;
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(592, 361);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(111, 39);
            this.btnXml.TabIndex = 9;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = true;
            // 
            // btnJsn
            // 
            this.btnJsn.Location = new System.Drawing.Point(786, 361);
            this.btnJsn.Name = "btnJsn";
            this.btnJsn.Size = new System.Drawing.Size(111, 39);
            this.btnJsn.TabIndex = 10;
            this.btnJsn.Text = "JSON";
            this.btnJsn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1097, 448);
            this.Controls.Add(this.btnJsn);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.lbSaveFormat);
            this.Controls.Add(this.lbNewStudent);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbBirthday);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Name = "Form1";
            this.Text = "Student Vueling University";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}