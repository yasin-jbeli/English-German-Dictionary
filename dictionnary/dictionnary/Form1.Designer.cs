namespace dictionnary
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "English-German Translator Englischer-Deutscher Übersetzer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(509, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Location = new System.Drawing.Point(509, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Word";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(509, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update Word";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(57, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Word : ";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Arbeiten",
            "Attraktiv",
            "Auto",
            "Buch",
            "Bleistift",
            "Blume",
            "Brief",
            "Brille",
            "Brötchen",
            "Butter",
            "Computer",
            "Dankbar",
            "Datum",
            "Draußen",
            "Drei",
            "Einfach",
            "Einladung",
            "Eis",
            "Erfolg",
            "Essen",
            "Fenster",
            "Feuer",
            "Flugzeug",
            "Foto",
            "Frei",
            "Freund",
            "Frühstück",
            "Fußball",
            "Führung",
            "Garten",
            "Geld",
            "Gesundheit",
            "Glas",
            "Gleich",
            "Globus",
            "Guten Morgen",
            "Guten Tag",
            "Gut",
            "Haustier",
            "Herbst",
            "Himmel",
            "Hobby",
            "Hochzeit",
            "Hose",
            "Hund",
            "Idee",
            "Imbiss",
            "Insel",
            "Interessant",
            "Jacke",
            "Jahr",
            "Kamera",
            "Karte",
            "Kaufhaus",
            "Keller",
            "Kennenlernen",
            "Kinder",
            "Kleid",
            "Koffer",
            "Kopf",
            "Korb",
            "Krankenhaus",
            "Kuchen",
            "Kugelschreiber",
            "Kuh",
            "Kühlschrank",
            "Kurs",
            "Lachen",
            "Lampe",
            "Länder",
            "Landwirtschaft",
            "Laptop",
            "Laterne",
            "Leben",
            "Lehrer",
            "Leidenschaft",
            "Leiter",
            "Leuchter",
            "Leute",
            "Lied",
            "Lift",
            "Lippenstift",
            "Löffel",
            "Löwe",
            "Mädchen",
            "Mahlzeit",
            "Maler",
            "Mama",
            "Mann",
            "Maschine",
            "Meer",
            "Meinung",
            "Melodie",
            "Mensch",
            "Messer",
            "Miete",
            "Milch",
            "Minute",
            "Missverständnis",
            "Mitte",
            "Mittwoch",
            "Mode",
            "Mond",
            "Morgen",
            "Motorrad",
            "Mund",
            "Musik",
            "Nacht",
            "Nagel",
            "Nase",
            "Natur",
            "Nebel",
            "Nerv",
            "Netz",
            "Neugier",
            "Notiz",
            "Obst",
            "Ohr",
            "Oktober",
            "Ort",
            "Paket",
            "Papier",
            "Park",
            "Pasta",
            "Pause",
            "Pferd",
            "Pflanze",
            "Pfund",
            "Pilz",
            "Plan",
            "Platz",
            "Post",
            "Problem",
            "Punkt",
            "Qualität",
            "Radtour",
            "Regen",
            "Reise",
            "Rezept",
            "Rezept",
            "Richtung",
            "Rind",
            "Rosen",
            "Salat",
            "Schatten",
            "Schlüssel",
            "Schnee",
            "Schnellzug",
            "Schuh",
            "Schule",
            "Schüssel",
            "Schwester",
            "See",
            "Seife",
            "Sommer",
            "Sonne",
            "Spiel",
            "Sport",
            "Sprache",
            "Stadt",
            "Stamm",
            "Strom",
            "Stuhl",
            "Supermarkt",
            "Tafel",
            "Tag",
            "Tasche",
            "Telefon",
            "Teller",
            "Text",
            "Tisch",
            "Tomate",
            "Tor",
            "Treppe",
            "Trockner",
            "Tuch",
            "Uhr",
            "Urlaub",
            "Vase",
            "Vogel",
            "Vorhang",
            "Wagen",
            "Wald",
            "Wand",
            "Wasser",
            "Welle",
            "Wetter",
            "Wind",
            "Wolke",
            "Wohnung",
            "Wort",
            "Wunsch",
            "Zeit",
            "Zettel",
            "Zimmer",
            "Zitrone",
            "Zug",
            "Zunge",
            "Zwillinge",
            "Abend",
            "Adresse",
            "Alter",
            "Angst",
            "Ankunft",
            "Anruf",
            "Anzug",
            "Apfel",
            "Arzt",
            "Atem",
            "Arbeit",
            "Asche",
            "Bahn",
            "Bank",
            "Bau",
            "Baum",
            "Berg",
            "Bett",
            "Bein",
            "Bild",
            "Boot",
            "Bus",
            "Dach",
            "Dank",
            "Dorf",
            "Dose",
            "Druck",
            "Durst",
            "Ei",
            "Eis",
            "Ente",
            "Erde",
            "Fahrzeug",
            "Familie",
            "Fisch",
            "Flasche",
            "Frosch",
            "Frühling",
            "Fuß",
            "Geburtstag",
            "Geschenk",
            "Gesicht",
            "Glocke",
            "Gras",
            "Grippe",
            "Großeltern",
            "Hahn",
            "Haus",
            "Hunger",
            "Kaffee",
            "Käse",
            "Kino",
            "Kochen",
            "Küche",
            "Kunst",
            "Lächeln",
            "Landschaft",
            "Laufen",
            "Leben",
            "Leicht",
            "Lernen",
            "Lesen",
            "Liebe",
            "To work",
            "Attractive",
            "Car",
            "Book",
            "Pencil",
            "Flower",
            "Letter",
            "Glasses",
            "Roll",
            "Butter",
            "Computer",
            "Grateful",
            "Date",
            "Outside",
            "Three",
            "Simple",
            "Invitation",
            "Ice cream",
            "Success",
            "Food",
            "Window",
            "Fire",
            "Airplane",
            "Photo",
            "Free",
            "Friend",
            "Breakfast",
            "Football/Soccer",
            "Guided tour",
            "Garden",
            "Money",
            "Health",
            "Glass",
            "Same/Equal",
            "Globe",
            "Good morning",
            "Good day",
            "Good",
            "Pet",
            "Autumn",
            "Sky",
            "Hobby",
            "Wedding",
            "Pants",
            "Dog",
            "Idea",
            "Snack",
            "Island",
            "Interesting",
            "Jacket",
            "Year",
            "Camera",
            "Card/Map",
            "Department store",
            "Basement",
            "To get to know",
            "Children",
            "Dress",
            "Suitcase",
            "Head",
            "Basket",
            "Hospital",
            "Cake",
            "Ballpoint pen",
            "Cow",
            "Refrigerator",
            "Course",
            "Laughter/To laugh",
            "Lamp",
            "Countries",
            "Agriculture",
            "Laptop",
            "Lantern",
            "Life/To live",
            "Teacher",
            "Passion",
            "Ladder",
            "Flashlight",
            "People",
            "Song",
            "Elevator",
            "Lipstick",
            "Spoon",
            "Lion",
            "Girl",
            "Mealtime",
            "Painter",
            "Mom",
            "Man",
            "Machine",
            "Sea",
            "Opinion",
            "Melody",
            "Human",
            "Knife",
            "Rent",
            "Milk",
            "Minute",
            "Misunderstanding",
            "Middle",
            "Wednesday",
            "Fashion",
            "Moon",
            "Morning",
            "Motorcycle",
            "Mouth",
            "Music",
            "Night",
            "Nail",
            "Nose",
            "Nature",
            "Fog",
            "Nerve",
            "Net",
            "Curiosity",
            "Note",
            "Fruit",
            "Ear",
            "October",
            "Place",
            "Package",
            "Paper",
            "Park",
            "Pasta",
            "Break",
            "Horse",
            "Plant",
            "Pound",
            "Mushroom",
            "Plan",
            "Place",
            "Mail",
            "Problem",
            "Point",
            "Quality",
            "Bike tour",
            "Rain",
            "Trip",
            "Recipe",
            "Prescription",
            "Direction",
            "Beef",
            "Roses",
            "Salad",
            "Shadow",
            "Key",
            "Snow",
            "Express train",
            "Shoe",
            "School",
            "Bowl",
            "Sister",
            "Lake",
            "Soap",
            "Summer",
            "Sun",
            "Game",
            "Sport",
            "Language",
            "City",
            "Trunk",
            "Electricity",
            "Chair",
            "Supermarket",
            "Chalkboard",
            "Day",
            "Bag",
            "Telephone",
            "Plate",
            "Text",
            "Table",
            "Tomato",
            "Gate",
            "Stairs",
            "Dryer",
            "Cloth",
            "Clock",
            "Vacation",
            "Vase",
            "Bird",
            "Curtain",
            "Car",
            "Forest",
            "Wall",
            "Water",
            "Wave",
            "Weather",
            "Wind",
            "Cloud",
            "Apartment",
            "Word",
            "Wish",
            "Time",
            "Note",
            "Room",
            "Lemon",
            "Train",
            "Tongue",
            "Twins",
            "Evening",
            "Address",
            "Age",
            "Fear",
            "Arrival",
            "Call",
            "Suit",
            "Apple",
            "Doctor",
            "Breath",
            "Work",
            "Ash",
            "Train",
            "Bank",
            "Construction",
            "Tree",
            "Mountain",
            "Bed",
            "Leg",
            "Picture",
            "Boat",
            "Bus",
            "Roof",
            "Thanks",
            "Village",
            "Can",
            "Pressure",
            "Thirst",
            "Egg",
            "Ice",
            "Duck",
            "Earth",
            "Vehicle",
            "Family",
            "Fish",
            "Bottle",
            "Frog",
            "Spring",
            "Foot",
            "Birthday",
            "Gift",
            "Face",
            "Bell",
            "Grass",
            "Flu",
            "Grandparents",
            "Rooster",
            "House",
            "Hunger",
            "Coffee",
            "Cheese",
            "Cinema",
            "To cook",
            "Kitchen",
            "Art",
            "To smile",
            "Landscape",
            "To run",
            "Life",
            "Light",
            "To learn",
            "To read",
            "Love"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.textBox1.Location = new System.Drawing.Point(219, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 28);
            this.textBox1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(62, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 36);
            this.button4.TabIndex = 6;
            this.button4.Text = "Translate";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBox2.Location = new System.Drawing.Point(62, 282);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 156);
            this.textBox2.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.radioButton1.Location = new System.Drawing.Point(235, 236);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(157, 25);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "English to german";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 8F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(418, 407);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 31);
            this.button5.TabIndex = 9;
            this.button5.Text = "alt";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(693, 336);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 48);
            this.button6.TabIndex = 11;
            this.button6.Text = "export";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(693, 390);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 48);
            this.button7.TabIndex = 12;
            this.button7.Text = "import";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "english-german translator Englischer-Deutscher Übersetzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

