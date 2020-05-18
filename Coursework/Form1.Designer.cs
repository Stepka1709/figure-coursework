namespace Coursework
{
    partial class FormFigure
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxFigure = new System.Windows.Forms.PictureBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonMovement = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonDefaultSize = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.trackBarRotationSpeed = new System.Windows.Forms.TrackBar();
            this.labelRotationSpeed = new System.Windows.Forms.Label();
            this.labelCoords = new System.Windows.Forms.Label();
            this.labelCoord = new System.Windows.Forms.Label();
            this.labelStarting = new System.Windows.Forms.Label();
            this.labelStartingX = new System.Windows.Forms.Label();
            this.labelStartingY = new System.Windows.Forms.Label();
            this.textBoxStartingX = new System.Windows.Forms.TextBox();
            this.textBoxStartingY = new System.Windows.Forms.TextBox();
            this.textBoxStartingDirectionY = new System.Windows.Forms.TextBox();
            this.textBoxStartingDirectionX = new System.Windows.Forms.TextBox();
            this.labelStartingDirectionY = new System.Windows.Forms.Label();
            this.labelStartingDirectionX = new System.Windows.Forms.Label();
            this.labelStartingDirection = new System.Windows.Forms.Label();
            this.buttonEnterCoord = new System.Windows.Forms.Button();
            this.labelErrors = new System.Windows.Forms.Label();
            this.timerMovement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFigure
            // 
            this.pictureBoxFigure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFigure.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFigure.Name = "pictureBoxFigure";
            this.pictureBoxFigure.Size = new System.Drawing.Size(707, 386);
            this.pictureBoxFigure.TabIndex = 0;
            this.pictureBoxFigure.TabStop = false;
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(911, 60);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(168, 46);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "Нарисовать фигуру";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonMovement
            // 
            this.buttonMovement.Location = new System.Drawing.Point(725, 248);
            this.buttonMovement.Name = "buttonMovement";
            this.buttonMovement.Size = new System.Drawing.Size(180, 46);
            this.buttonMovement.TabIndex = 2;
            this.buttonMovement.Text = "Движение фигуры";
            this.buttonMovement.UseVisualStyleBackColor = true;
            this.buttonMovement.Click += new System.EventHandler(this.buttonMovement_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(725, 300);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(180, 46);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Остановить фигуру";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonDefaultSize
            // 
            this.buttonDefaultSize.Location = new System.Drawing.Point(725, 352);
            this.buttonDefaultSize.Name = "buttonDefaultSize";
            this.buttonDefaultSize.Size = new System.Drawing.Size(180, 46);
            this.buttonDefaultSize.TabIndex = 4;
            this.buttonDefaultSize.Text = "Размер по умолчанию";
            this.buttonDefaultSize.UseVisualStyleBackColor = true;
            this.buttonDefaultSize.Click += new System.EventHandler(this.buttonDefaultSize_Click);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(722, 12);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(114, 17);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "Размер фигуры:";
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(725, 32);
            this.trackBarSize.Maximum = 80;
            this.trackBarSize.Minimum = 40;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(177, 56);
            this.trackBarSize.TabIndex = 6;
            this.trackBarSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSize.Value = 40;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(725, 94);
            this.trackBarSpeed.Maximum = 5;
            this.trackBarSpeed.Minimum = 1;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(177, 56);
            this.trackBarSpeed.TabIndex = 8;
            this.trackBarSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSpeed.Value = 1;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(722, 74);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(126, 17);
            this.labelSpeed.TabIndex = 7;
            this.labelSpeed.Text = "Скорость фигуры:";
            // 
            // trackBarRotationSpeed
            // 
            this.trackBarRotationSpeed.Location = new System.Drawing.Point(725, 156);
            this.trackBarRotationSpeed.Maximum = 5;
            this.trackBarRotationSpeed.Minimum = 1;
            this.trackBarRotationSpeed.Name = "trackBarRotationSpeed";
            this.trackBarRotationSpeed.Size = new System.Drawing.Size(177, 56);
            this.trackBarRotationSpeed.TabIndex = 10;
            this.trackBarRotationSpeed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRotationSpeed.Value = 1;
            this.trackBarRotationSpeed.Scroll += new System.EventHandler(this.trackBarRotationSpeed_Scroll);
            // 
            // labelRotationSpeed
            // 
            this.labelRotationSpeed.AutoSize = true;
            this.labelRotationSpeed.Location = new System.Drawing.Point(722, 133);
            this.labelRotationSpeed.Name = "labelRotationSpeed";
            this.labelRotationSpeed.Size = new System.Drawing.Size(143, 17);
            this.labelRotationSpeed.TabIndex = 9;
            this.labelRotationSpeed.Text = "Скорость вращения:";
            // 
            // labelCoords
            // 
            this.labelCoords.AutoSize = true;
            this.labelCoords.Location = new System.Drawing.Point(722, 198);
            this.labelCoords.Name = "labelCoords";
            this.labelCoords.Size = new System.Drawing.Size(94, 17);
            this.labelCoords.TabIndex = 11;
            this.labelCoords.Text = "Координаты:";
            // 
            // labelCoord
            // 
            this.labelCoord.AutoSize = true;
            this.labelCoord.Location = new System.Drawing.Point(722, 215);
            this.labelCoord.Name = "labelCoord";
            this.labelCoord.Size = new System.Drawing.Size(106, 17);
            this.labelCoord.TabIndex = 12;
            this.labelCoord.Text = "X: 0,00, Y: 0,00";
            // 
            // labelStarting
            // 
            this.labelStarting.AutoSize = true;
            this.labelStarting.Location = new System.Drawing.Point(908, 12);
            this.labelStarting.Name = "labelStarting";
            this.labelStarting.Size = new System.Drawing.Size(171, 17);
            this.labelStarting.TabIndex = 13;
            this.labelStarting.Text = "Начальные координаты:";
            // 
            // labelStartingX
            // 
            this.labelStartingX.AutoSize = true;
            this.labelStartingX.Location = new System.Drawing.Point(908, 35);
            this.labelStartingX.Name = "labelStartingX";
            this.labelStartingX.Size = new System.Drawing.Size(21, 17);
            this.labelStartingX.TabIndex = 14;
            this.labelStartingX.Text = "X:";
            // 
            // labelStartingY
            // 
            this.labelStartingY.AutoSize = true;
            this.labelStartingY.Location = new System.Drawing.Point(976, 35);
            this.labelStartingY.Name = "labelStartingY";
            this.labelStartingY.Size = new System.Drawing.Size(21, 17);
            this.labelStartingY.TabIndex = 15;
            this.labelStartingY.Text = "Y:";
            // 
            // textBoxStartingX
            // 
            this.textBoxStartingX.Location = new System.Drawing.Point(935, 32);
            this.textBoxStartingX.Name = "textBoxStartingX";
            this.textBoxStartingX.Size = new System.Drawing.Size(33, 22);
            this.textBoxStartingX.TabIndex = 16;
            this.textBoxStartingX.TextChanged += new System.EventHandler(this.textBoxStartingX_TextChanged);
            // 
            // textBoxStartingY
            // 
            this.textBoxStartingY.Location = new System.Drawing.Point(1003, 32);
            this.textBoxStartingY.Name = "textBoxStartingY";
            this.textBoxStartingY.Size = new System.Drawing.Size(33, 22);
            this.textBoxStartingY.TabIndex = 17;
            this.textBoxStartingY.TextChanged += new System.EventHandler(this.textBoxStartingY_TextChanged);
            // 
            // textBoxStartingDirectionY
            // 
            this.textBoxStartingDirectionY.Location = new System.Drawing.Point(1003, 129);
            this.textBoxStartingDirectionY.Name = "textBoxStartingDirectionY";
            this.textBoxStartingDirectionY.Size = new System.Drawing.Size(33, 22);
            this.textBoxStartingDirectionY.TabIndex = 22;
            this.textBoxStartingDirectionY.TextChanged += new System.EventHandler(this.textBoxStartingDirectionY_TextChanged);
            // 
            // textBoxStartingDirectionX
            // 
            this.textBoxStartingDirectionX.Location = new System.Drawing.Point(935, 129);
            this.textBoxStartingDirectionX.Name = "textBoxStartingDirectionX";
            this.textBoxStartingDirectionX.Size = new System.Drawing.Size(33, 22);
            this.textBoxStartingDirectionX.TabIndex = 21;
            this.textBoxStartingDirectionX.TextChanged += new System.EventHandler(this.textBoxStartingDirectionX_TextChanged);
            // 
            // labelStartingDirectionY
            // 
            this.labelStartingDirectionY.AutoSize = true;
            this.labelStartingDirectionY.Location = new System.Drawing.Point(976, 132);
            this.labelStartingDirectionY.Name = "labelStartingDirectionY";
            this.labelStartingDirectionY.Size = new System.Drawing.Size(21, 17);
            this.labelStartingDirectionY.TabIndex = 20;
            this.labelStartingDirectionY.Text = "Y:";
            // 
            // labelStartingDirectionX
            // 
            this.labelStartingDirectionX.AutoSize = true;
            this.labelStartingDirectionX.Location = new System.Drawing.Point(908, 132);
            this.labelStartingDirectionX.Name = "labelStartingDirectionX";
            this.labelStartingDirectionX.Size = new System.Drawing.Size(21, 17);
            this.labelStartingDirectionX.TabIndex = 19;
            this.labelStartingDirectionX.Text = "X:";
            // 
            // labelStartingDirection
            // 
            this.labelStartingDirection.AutoSize = true;
            this.labelStartingDirection.Location = new System.Drawing.Point(908, 109);
            this.labelStartingDirection.Name = "labelStartingDirection";
            this.labelStartingDirection.Size = new System.Drawing.Size(176, 17);
            this.labelStartingDirection.TabIndex = 18;
            this.labelStartingDirection.Text = "Начальное направление:";
            // 
            // buttonEnterCoord
            // 
            this.buttonEnterCoord.Location = new System.Drawing.Point(911, 157);
            this.buttonEnterCoord.Name = "buttonEnterCoord";
            this.buttonEnterCoord.Size = new System.Drawing.Size(168, 46);
            this.buttonEnterCoord.TabIndex = 23;
            this.buttonEnterCoord.Text = "Ввести координаты";
            this.buttonEnterCoord.UseVisualStyleBackColor = true;
            this.buttonEnterCoord.Click += new System.EventHandler(this.buttonEnterCoord_Click);
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.ForeColor = System.Drawing.Color.Red;
            this.labelErrors.Location = new System.Drawing.Point(12, 401);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(169, 17);
            this.labelErrors.TabIndex = 24;
            this.labelErrors.Text = "Ошибок не обнаружено.";
            // 
            // timerMovement
            // 
            this.timerMovement.Interval = 10;
            this.timerMovement.Tick += new System.EventHandler(this.timerMovement_Tick);
            // 
            // FormFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 427);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.buttonEnterCoord);
            this.Controls.Add(this.textBoxStartingDirectionY);
            this.Controls.Add(this.textBoxStartingDirectionX);
            this.Controls.Add(this.labelStartingDirectionY);
            this.Controls.Add(this.labelStartingDirectionX);
            this.Controls.Add(this.labelStartingDirection);
            this.Controls.Add(this.textBoxStartingY);
            this.Controls.Add(this.textBoxStartingX);
            this.Controls.Add(this.labelStartingY);
            this.Controls.Add(this.labelStartingX);
            this.Controls.Add(this.labelStarting);
            this.Controls.Add(this.labelCoord);
            this.Controls.Add(this.labelCoords);
            this.Controls.Add(this.trackBarRotationSpeed);
            this.Controls.Add(this.labelRotationSpeed);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.buttonDefaultSize);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonMovement);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.pictureBoxFigure);
            this.MaximizeBox = false;
            this.Name = "FormFigure";
            this.ShowIcon = false;
            this.Text = "Программа";
            this.Load += new System.EventHandler(this.FormFigure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFigure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFigure;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonMovement;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonDefaultSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TrackBar trackBarRotationSpeed;
        private System.Windows.Forms.Label labelRotationSpeed;
        private System.Windows.Forms.Label labelCoords;
        private System.Windows.Forms.Label labelCoord;
        private System.Windows.Forms.Label labelStarting;
        private System.Windows.Forms.Label labelStartingX;
        private System.Windows.Forms.Label labelStartingY;
        private System.Windows.Forms.TextBox textBoxStartingX;
        private System.Windows.Forms.TextBox textBoxStartingY;
        private System.Windows.Forms.TextBox textBoxStartingDirectionY;
        private System.Windows.Forms.TextBox textBoxStartingDirectionX;
        private System.Windows.Forms.Label labelStartingDirectionY;
        private System.Windows.Forms.Label labelStartingDirectionX;
        private System.Windows.Forms.Label labelStartingDirection;
        private System.Windows.Forms.Button buttonEnterCoord;
        private System.Windows.Forms.Label labelErrors;
        private System.Windows.Forms.Timer timerMovement;
    }
}

