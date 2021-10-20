
namespace DrinkProduction
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelDrink = new System.Windows.Forms.Label();
            this.labelJuice = new System.Windows.Forms.Label();
            this.labelKvass = new System.Windows.Forms.Label();
            this.labelWine = new System.Windows.Forms.Label();
            this.buttonCreateDrink = new System.Windows.Forms.Button();
            this.textBoxDrink = new System.Windows.Forms.TextBox();
            this.labelDrinkInf = new System.Windows.Forms.Label();
            this.buttonDrinkProduct = new System.Windows.Forms.Button();
            this.buttonJuiceProduction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxJuice = new System.Windows.Forms.TextBox();
            this.buttonCreateJuice = new System.Windows.Forms.Button();
            this.buttonKvassProduction = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKvass = new System.Windows.Forms.TextBox();
            this.buttonCreateKvass = new System.Windows.Forms.Button();
            this.buttonWineProduction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWine = new System.Windows.Forms.TextBox();
            this.buttonCreateWine = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonDrinkInfo = new System.Windows.Forms.Button();
            this.buttonJuiceInfo = new System.Windows.Forms.Button();
            this.buttonKvassInfo = new System.Windows.Forms.Button();
            this.buttonWineInfo = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSaveRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDrink
            // 
            this.labelDrink.AutoSize = true;
            this.labelDrink.BackColor = System.Drawing.Color.White;
            this.labelDrink.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDrink.Location = new System.Drawing.Point(69, 53);
            this.labelDrink.Name = "labelDrink";
            this.labelDrink.Size = new System.Drawing.Size(145, 35);
            this.labelDrink.TabIndex = 0;
            this.labelDrink.Text = "Напиток";
            // 
            // labelJuice
            // 
            this.labelJuice.AutoSize = true;
            this.labelJuice.BackColor = System.Drawing.Color.White;
            this.labelJuice.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelJuice.Location = new System.Drawing.Point(322, 53);
            this.labelJuice.Name = "labelJuice";
            this.labelJuice.Size = new System.Drawing.Size(72, 35);
            this.labelJuice.TabIndex = 1;
            this.labelJuice.Text = "Сок";
            // 
            // labelKvass
            // 
            this.labelKvass.AutoSize = true;
            this.labelKvass.BackColor = System.Drawing.Color.White;
            this.labelKvass.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKvass.Location = new System.Drawing.Point(535, 53);
            this.labelKvass.Name = "labelKvass";
            this.labelKvass.Size = new System.Drawing.Size(83, 35);
            this.labelKvass.TabIndex = 2;
            this.labelKvass.Text = "Квас";
            // 
            // labelWine
            // 
            this.labelWine.AutoSize = true;
            this.labelWine.BackColor = System.Drawing.Color.White;
            this.labelWine.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWine.Location = new System.Drawing.Point(745, 53);
            this.labelWine.Name = "labelWine";
            this.labelWine.Size = new System.Drawing.Size(92, 35);
            this.labelWine.TabIndex = 3;
            this.labelWine.Text = "Вино";
            // 
            // buttonCreateDrink
            // 
            this.buttonCreateDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCreateDrink.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateDrink.Location = new System.Drawing.Point(59, 108);
            this.buttonCreateDrink.Name = "buttonCreateDrink";
            this.buttonCreateDrink.Size = new System.Drawing.Size(147, 81);
            this.buttonCreateDrink.TabIndex = 4;
            this.buttonCreateDrink.Text = "Создать объект";
            this.buttonCreateDrink.UseVisualStyleBackColor = false;
            this.buttonCreateDrink.Click += new System.EventHandler(this.buttonCreateDrink_Click);
            // 
            // textBoxDrink
            // 
            this.textBoxDrink.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDrink.Location = new System.Drawing.Point(59, 314);
            this.textBoxDrink.Name = "textBoxDrink";
            this.textBoxDrink.Size = new System.Drawing.Size(147, 40);
            this.textBoxDrink.TabIndex = 5;
            this.textBoxDrink.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDrink_KeyPress);
            // 
            // labelDrinkInf
            // 
            this.labelDrinkInf.AutoSize = true;
            this.labelDrinkInf.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDrinkInf.Location = new System.Drawing.Point(55, 289);
            this.labelDrinkInf.Name = "labelDrinkInf";
            this.labelDrinkInf.Size = new System.Drawing.Size(196, 27);
            this.labelDrinkInf.TabIndex = 6;
            this.labelDrinkInf.Text = "Произвести литров:";
            // 
            // buttonDrinkProduct
            // 
            this.buttonDrinkProduct.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrinkProduct.Location = new System.Drawing.Point(59, 363);
            this.buttonDrinkProduct.Name = "buttonDrinkProduct";
            this.buttonDrinkProduct.Size = new System.Drawing.Size(147, 33);
            this.buttonDrinkProduct.TabIndex = 7;
            this.buttonDrinkProduct.Text = "Производство";
            this.buttonDrinkProduct.UseVisualStyleBackColor = true;
            this.buttonDrinkProduct.Click += new System.EventHandler(this.buttonDrinkProduct_Click);
            // 
            // buttonJuiceProduction
            // 
            this.buttonJuiceProduction.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJuiceProduction.Location = new System.Drawing.Point(276, 363);
            this.buttonJuiceProduction.Name = "buttonJuiceProduction";
            this.buttonJuiceProduction.Size = new System.Drawing.Size(147, 33);
            this.buttonJuiceProduction.TabIndex = 11;
            this.buttonJuiceProduction.Text = "Производство";
            this.buttonJuiceProduction.UseVisualStyleBackColor = true;
            this.buttonJuiceProduction.Click += new System.EventHandler(this.buttonJuiceProduction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Произвести литров:";
            // 
            // textBoxJuice
            // 
            this.textBoxJuice.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJuice.Location = new System.Drawing.Point(276, 314);
            this.textBoxJuice.Name = "textBoxJuice";
            this.textBoxJuice.Size = new System.Drawing.Size(147, 40);
            this.textBoxJuice.TabIndex = 9;
            this.textBoxJuice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxJuice_KeyPress);
            // 
            // buttonCreateJuice
            // 
            this.buttonCreateJuice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCreateJuice.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateJuice.Location = new System.Drawing.Point(276, 108);
            this.buttonCreateJuice.Name = "buttonCreateJuice";
            this.buttonCreateJuice.Size = new System.Drawing.Size(147, 81);
            this.buttonCreateJuice.TabIndex = 8;
            this.buttonCreateJuice.Text = "Создать объект";
            this.buttonCreateJuice.UseVisualStyleBackColor = false;
            this.buttonCreateJuice.Click += new System.EventHandler(this.buttonCreateJuice_Click);
            // 
            // buttonKvassProduction
            // 
            this.buttonKvassProduction.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKvassProduction.Location = new System.Drawing.Point(492, 363);
            this.buttonKvassProduction.Name = "buttonKvassProduction";
            this.buttonKvassProduction.Size = new System.Drawing.Size(147, 33);
            this.buttonKvassProduction.TabIndex = 15;
            this.buttonKvassProduction.Text = "Производство";
            this.buttonKvassProduction.UseVisualStyleBackColor = true;
            this.buttonKvassProduction.Click += new System.EventHandler(this.buttonKvassProduction_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Произвести литров:";
            // 
            // textBoxKvass
            // 
            this.textBoxKvass.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKvass.Location = new System.Drawing.Point(492, 314);
            this.textBoxKvass.Name = "textBoxKvass";
            this.textBoxKvass.Size = new System.Drawing.Size(147, 40);
            this.textBoxKvass.TabIndex = 13;
            this.textBoxKvass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKvass_KeyPress);
            // 
            // buttonCreateKvass
            // 
            this.buttonCreateKvass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCreateKvass.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateKvass.Location = new System.Drawing.Point(492, 108);
            this.buttonCreateKvass.Name = "buttonCreateKvass";
            this.buttonCreateKvass.Size = new System.Drawing.Size(147, 81);
            this.buttonCreateKvass.TabIndex = 12;
            this.buttonCreateKvass.Text = "Создать объект";
            this.buttonCreateKvass.UseVisualStyleBackColor = false;
            this.buttonCreateKvass.Click += new System.EventHandler(this.buttonCreateKvass_Click);
            // 
            // buttonWineProduction
            // 
            this.buttonWineProduction.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWineProduction.Location = new System.Drawing.Point(709, 363);
            this.buttonWineProduction.Name = "buttonWineProduction";
            this.buttonWineProduction.Size = new System.Drawing.Size(147, 33);
            this.buttonWineProduction.TabIndex = 19;
            this.buttonWineProduction.Text = "Производство";
            this.buttonWineProduction.UseVisualStyleBackColor = true;
            this.buttonWineProduction.Click += new System.EventHandler(this.buttonWineProduction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(705, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Произвести литров:";
            // 
            // textBoxWine
            // 
            this.textBoxWine.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWine.Location = new System.Drawing.Point(709, 314);
            this.textBoxWine.Name = "textBoxWine";
            this.textBoxWine.Size = new System.Drawing.Size(147, 40);
            this.textBoxWine.TabIndex = 17;
            this.textBoxWine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWine_KeyPress);
            // 
            // buttonCreateWine
            // 
            this.buttonCreateWine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCreateWine.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateWine.Location = new System.Drawing.Point(709, 108);
            this.buttonCreateWine.Name = "buttonCreateWine";
            this.buttonCreateWine.Size = new System.Drawing.Size(147, 81);
            this.buttonCreateWine.TabIndex = 16;
            this.buttonCreateWine.Text = "Создать объект";
            this.buttonCreateWine.UseVisualStyleBackColor = false;
            this.buttonCreateWine.Click += new System.EventHandler(this.buttonCreateWine_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonRecord.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecord.Location = new System.Drawing.Point(304, 428);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(314, 70);
            this.buttonRecord.TabIndex = 20;
            this.buttonRecord.Text = "Отчёт по производству";
            this.buttonRecord.UseVisualStyleBackColor = false;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // buttonDrinkInfo
            // 
            this.buttonDrinkInfo.BackColor = System.Drawing.Color.LightCyan;
            this.buttonDrinkInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDrinkInfo.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrinkInfo.Location = new System.Drawing.Point(59, 206);
            this.buttonDrinkInfo.Name = "buttonDrinkInfo";
            this.buttonDrinkInfo.Size = new System.Drawing.Size(147, 67);
            this.buttonDrinkInfo.TabIndex = 21;
            this.buttonDrinkInfo.Text = "Информация об объекте";
            this.buttonDrinkInfo.UseVisualStyleBackColor = false;
            this.buttonDrinkInfo.Click += new System.EventHandler(this.buttonDrinkInfo_Click);
            // 
            // buttonJuiceInfo
            // 
            this.buttonJuiceInfo.BackColor = System.Drawing.Color.LightCyan;
            this.buttonJuiceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonJuiceInfo.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJuiceInfo.Location = new System.Drawing.Point(276, 206);
            this.buttonJuiceInfo.Name = "buttonJuiceInfo";
            this.buttonJuiceInfo.Size = new System.Drawing.Size(147, 67);
            this.buttonJuiceInfo.TabIndex = 22;
            this.buttonJuiceInfo.Text = "Информация об объекте";
            this.buttonJuiceInfo.UseVisualStyleBackColor = false;
            this.buttonJuiceInfo.Click += new System.EventHandler(this.buttonJuiceInfo_Click);
            // 
            // buttonKvassInfo
            // 
            this.buttonKvassInfo.BackColor = System.Drawing.Color.LightCyan;
            this.buttonKvassInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKvassInfo.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKvassInfo.Location = new System.Drawing.Point(492, 206);
            this.buttonKvassInfo.Name = "buttonKvassInfo";
            this.buttonKvassInfo.Size = new System.Drawing.Size(147, 67);
            this.buttonKvassInfo.TabIndex = 23;
            this.buttonKvassInfo.Text = "Информация об объекте";
            this.buttonKvassInfo.UseVisualStyleBackColor = false;
            this.buttonKvassInfo.Click += new System.EventHandler(this.buttonKvassInfo_Click);
            // 
            // buttonWineInfo
            // 
            this.buttonWineInfo.BackColor = System.Drawing.Color.LightCyan;
            this.buttonWineInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWineInfo.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWineInfo.Location = new System.Drawing.Point(709, 206);
            this.buttonWineInfo.Name = "buttonWineInfo";
            this.buttonWineInfo.Size = new System.Drawing.Size(147, 67);
            this.buttonWineInfo.TabIndex = 24;
            this.buttonWineInfo.Text = "Информация об объекте";
            this.buttonWineInfo.UseVisualStyleBackColor = false;
            this.buttonWineInfo.Click += new System.EventHandler(this.buttonWineInfo_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose.Location = new System.Drawing.Point(59, 466);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 31);
            this.buttonClose.TabIndex = 25;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSaveRecord
            // 
            this.buttonSaveRecord.BackColor = System.Drawing.Color.White;
            this.buttonSaveRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveRecord.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveRecord.Location = new System.Drawing.Point(652, 455);
            this.buttonSaveRecord.Name = "buttonSaveRecord";
            this.buttonSaveRecord.Size = new System.Drawing.Size(218, 42);
            this.buttonSaveRecord.TabIndex = 26;
            this.buttonSaveRecord.Text = "сохранить отчет в файл";
            this.buttonSaveRecord.UseVisualStyleBackColor = false;
            this.buttonSaveRecord.Click += new System.EventHandler(this.buttonSaveRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 520);
            this.Controls.Add(this.buttonSaveRecord);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonWineInfo);
            this.Controls.Add(this.buttonKvassInfo);
            this.Controls.Add(this.buttonJuiceInfo);
            this.Controls.Add(this.buttonDrinkInfo);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.buttonWineProduction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWine);
            this.Controls.Add(this.buttonCreateWine);
            this.Controls.Add(this.buttonKvassProduction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKvass);
            this.Controls.Add(this.buttonCreateKvass);
            this.Controls.Add(this.buttonJuiceProduction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxJuice);
            this.Controls.Add(this.buttonCreateJuice);
            this.Controls.Add(this.buttonDrinkProduct);
            this.Controls.Add(this.labelDrinkInf);
            this.Controls.Add(this.textBoxDrink);
            this.Controls.Add(this.buttonCreateDrink);
            this.Controls.Add(this.labelWine);
            this.Controls.Add(this.labelKvass);
            this.Controls.Add(this.labelJuice);
            this.Controls.Add(this.labelDrink);
            this.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrinkProduction";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDrink;
        private System.Windows.Forms.Label labelJuice;
        private System.Windows.Forms.Label labelKvass;
        private System.Windows.Forms.Label labelWine;
        private System.Windows.Forms.Button buttonCreateDrink;
        private System.Windows.Forms.TextBox textBoxDrink;
        private System.Windows.Forms.Label labelDrinkInf;
        private System.Windows.Forms.Button buttonDrinkProduct;
        private System.Windows.Forms.Button buttonJuiceProduction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxJuice;
        private System.Windows.Forms.Button buttonCreateJuice;
        private System.Windows.Forms.Button buttonKvassProduction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKvass;
        private System.Windows.Forms.Button buttonCreateKvass;
        private System.Windows.Forms.Button buttonWineProduction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWine;
        private System.Windows.Forms.Button buttonCreateWine;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonDrinkInfo;
        private System.Windows.Forms.Button buttonJuiceInfo;
        private System.Windows.Forms.Button buttonKvassInfo;
        private System.Windows.Forms.Button buttonWineInfo;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSaveRecord;
    }
}

