namespace ToysShop
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.checkBoxBear = new System.Windows.Forms.CheckBox();
            this.checkBoxLEGOSet = new System.Windows.Forms.CheckBox();
            this.checkBoxSetOfSoldiers = new System.Windows.Forms.CheckBox();
            this.checkBoxRadioCar = new System.Windows.Forms.CheckBox();
            this.checkBoxBarbiDoll = new System.Windows.Forms.CheckBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPrices = new System.Windows.Forms.Button();
            this.PictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.textBoxPrices = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxBear
            // 
            this.checkBoxBear.AutoSize = true;
            this.checkBoxBear.Location = new System.Drawing.Point(11, 154);
            this.checkBoxBear.Name = "checkBoxBear";
            this.checkBoxBear.Size = new System.Drawing.Size(130, 17);
            this.checkBoxBear.TabIndex = 0;
            this.checkBoxBear.Text = "Плюшевый Медведь";
            this.checkBoxBear.UseVisualStyleBackColor = true;
            // 
            // checkBoxLEGOSet
            // 
            this.checkBoxLEGOSet.AutoSize = true;
            this.checkBoxLEGOSet.Location = new System.Drawing.Point(11, 177);
            this.checkBoxLEGOSet.Name = "checkBoxLEGOSet";
            this.checkBoxLEGOSet.Size = new System.Drawing.Size(90, 17);
            this.checkBoxLEGOSet.TabIndex = 1;
            this.checkBoxLEGOSet.Text = "Набор LEGO";
            this.checkBoxLEGOSet.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetOfSoldiers
            // 
            this.checkBoxSetOfSoldiers.AutoSize = true;
            this.checkBoxSetOfSoldiers.Location = new System.Drawing.Point(11, 200);
            this.checkBoxSetOfSoldiers.Name = "checkBoxSetOfSoldiers";
            this.checkBoxSetOfSoldiers.Size = new System.Drawing.Size(120, 17);
            this.checkBoxSetOfSoldiers.TabIndex = 2;
            this.checkBoxSetOfSoldiers.Text = "Набор солдатиков";
            this.checkBoxSetOfSoldiers.UseVisualStyleBackColor = true;
            // 
            // checkBoxRadioCar
            // 
            this.checkBoxRadioCar.AutoSize = true;
            this.checkBoxRadioCar.Location = new System.Drawing.Point(12, 223);
            this.checkBoxRadioCar.Name = "checkBoxRadioCar";
            this.checkBoxRadioCar.Size = new System.Drawing.Size(176, 17);
            this.checkBoxRadioCar.TabIndex = 3;
            this.checkBoxRadioCar.Text = "Радио управляемая машинка";
            this.checkBoxRadioCar.UseVisualStyleBackColor = true;
            // 
            // checkBoxBarbiDoll
            // 
            this.checkBoxBarbiDoll.AutoSize = true;
            this.checkBoxBarbiDoll.Location = new System.Drawing.Point(12, 246);
            this.checkBoxBarbiDoll.Name = "checkBoxBarbiDoll";
            this.checkBoxBarbiDoll.Size = new System.Drawing.Size(89, 17);
            this.checkBoxBarbiDoll.TabIndex = 4;
            this.checkBoxBarbiDoll.Text = "Кукла барби";
            this.checkBoxBarbiDoll.UseVisualStyleBackColor = true;
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(30, 282);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(101, 27);
            this.buttonCount.TabIndex = 5;
            this.buttonCount.Text = "Посчитать";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(137, 283);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(101, 26);
            this.buttonInfo.TabIndex = 6;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(244, 282);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(101, 27);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPrices
            // 
            this.buttonPrices.Location = new System.Drawing.Point(217, 154);
            this.buttonPrices.Name = "buttonPrices";
            this.buttonPrices.Size = new System.Drawing.Size(101, 26);
            this.buttonPrices.TabIndex = 8;
            this.buttonPrices.Text = "Цены";
            this.buttonPrices.UseVisualStyleBackColor = true;
            this.buttonPrices.Click += new System.EventHandler(this.buttonPrices_Click);
            // 
            // PictureBoxIcon
            // 
            this.PictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxIcon.Image")));
            this.PictureBoxIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxIcon.InitialImage")));
            this.PictureBoxIcon.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxIcon.Name = "PictureBoxIcon";
            this.PictureBoxIcon.Size = new System.Drawing.Size(141, 128);
            this.PictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxIcon.TabIndex = 9;
            this.PictureBoxIcon.TabStop = false;
            // 
            // textBoxPrices
            // 
            this.textBoxPrices.Location = new System.Drawing.Point(184, 12);
            this.textBoxPrices.Multiline = true;
            this.textBoxPrices.Name = "textBoxPrices";
            this.textBoxPrices.Size = new System.Drawing.Size(161, 128);
            this.textBoxPrices.TabIndex = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 321);
            this.Controls.Add(this.textBoxPrices);
            this.Controls.Add(this.PictureBoxIcon);
            this.Controls.Add(this.buttonPrices);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.checkBoxBarbiDoll);
            this.Controls.Add(this.checkBoxRadioCar);
            this.Controls.Add(this.checkBoxSetOfSoldiers);
            this.Controls.Add(this.checkBoxLEGOSet);
            this.Controls.Add(this.checkBoxBear);
            this.Name = "FormMain";
            this.Text = "Стоимость покупки";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxBear;
        private System.Windows.Forms.CheckBox checkBoxLEGOSet;
        private System.Windows.Forms.CheckBox checkBoxSetOfSoldiers;
        private System.Windows.Forms.CheckBox checkBoxRadioCar;
        private System.Windows.Forms.CheckBox checkBoxBarbiDoll;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPrices;
        private System.Windows.Forms.PictureBox PictureBoxIcon;
        private System.Windows.Forms.TextBox textBoxPrices;
    }
}

