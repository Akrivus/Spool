namespace Spool
{
    partial class DialogDataEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DialogTrigger = new System.Windows.Forms.ComboBox();
            this.DialogConditions = new System.Windows.Forms.ListBox();
            this.ConditionContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteCondition = new System.Windows.Forms.ToolStripMenuItem();
            this.DialogConditonSubmit = new System.Windows.Forms.Button();
            this.DialogConditionForm = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DialogReaction = new System.Windows.Forms.ComboBox();
            this.DialogEmotion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DialogMessage = new System.Windows.Forms.TextBox();
            this.DialogClose = new System.Windows.Forms.Button();
            this.DialogSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ConditionContextMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DialogTrigger);
            this.groupBox1.Controls.Add(this.DialogConditions);
            this.groupBox1.Controls.Add(this.DialogConditonSubmit);
            this.groupBox1.Controls.Add(this.DialogConditionForm);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conditions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trigger";
            // 
            // DialogTrigger
            // 
            this.DialogTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DialogTrigger.FormattingEnabled = true;
            this.DialogTrigger.Items.AddRange(new object[] {
            "interaction",
            "response_continue",
            "response_yes",
            "response_no",
            "response_heart",
            "response_armor",
            "response_skull",
            "random_nearby",
            "random_far",
            "stare",
            "good_gift",
            "normal_gift",
            "bad_gift",
            "flower",
            "flower_dandelion",
            "flower_poppy",
            "flower_blue_orchid",
            "flower_allium",
            "flower_azure_bluet",
            "flower_red_tulip",
            "flower_pink_tulip",
            "flower_white_tulip",
            "flower_orange_tulip",
            "flower_oxeye_daisy",
            "flower_cornflower",
            "flower_lily_of_the_valley",
            "flower_wither_rose",
            "flower_sunflower",
            "flower_lilac",
            "flower_rose",
            "flower_peony",
            "equip"});
            this.DialogTrigger.Location = new System.Drawing.Point(62, 134);
            this.DialogTrigger.Name = "DialogTrigger";
            this.DialogTrigger.Size = new System.Drawing.Size(300, 21);
            this.DialogTrigger.TabIndex = 3;
            // 
            // DialogConditions
            // 
            this.DialogConditions.ContextMenuStrip = this.ConditionContextMenu;
            this.DialogConditions.FormattingEnabled = true;
            this.DialogConditions.Location = new System.Drawing.Point(6, 46);
            this.DialogConditions.Name = "DialogConditions";
            this.DialogConditions.Size = new System.Drawing.Size(356, 82);
            this.DialogConditions.TabIndex = 2;
            // 
            // ConditionContextMenu
            // 
            this.ConditionContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteCondition});
            this.ConditionContextMenu.Name = "ConditionContextMenu";
            this.ConditionContextMenu.Size = new System.Drawing.Size(132, 26);
            // 
            // DeleteCondition
            // 
            this.DeleteCondition.Name = "DeleteCondition";
            this.DeleteCondition.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteCondition.Size = new System.Drawing.Size(131, 22);
            this.DeleteCondition.Text = "Delete";
            this.DeleteCondition.Click += new System.EventHandler(this.DeleteCondition_Click);
            // 
            // DialogConditonSubmit
            // 
            this.DialogConditonSubmit.Location = new System.Drawing.Point(287, 17);
            this.DialogConditonSubmit.Name = "DialogConditonSubmit";
            this.DialogConditonSubmit.Size = new System.Drawing.Size(75, 23);
            this.DialogConditonSubmit.TabIndex = 1;
            this.DialogConditonSubmit.Text = "Add";
            this.DialogConditonSubmit.UseVisualStyleBackColor = true;
            this.DialogConditonSubmit.Click += new System.EventHandler(this.DialogConditonSubmit_Click);
            // 
            // DialogConditionForm
            // 
            this.DialogConditionForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DialogConditionForm.FormattingEnabled = true;
            this.DialogConditionForm.Items.AddRange(new object[] {
            "always",
            "male",
            "female",
            "neko",
            "himedere",
            "kuudere",
            "tsundere",
            "yandere",
            "deredere",
            "dandere",
            "not_himedere",
            "not_kuudere",
            "not_tsundere",
            "not_yandere",
            "not_deredere",
            "not_dandere",
            "blood_type_o",
            "blood_type_a",
            "blood_type_b",
            "blood_type_ab",
            "not_blood_type_o",
            "not_blood_type_a",
            "not_blood_type_b",
            "not_blood_type_ab",
            "angry",
            "begging",
            "confused",
            "crying",
            "mischievous",
            "embarassed",
            "happy",
            "normal",
            "pained",
            "psychotic",
            "scared",
            "snooty",
            "smitten",
            "tired",
            "not_angry",
            "not_begging",
            "not_confused",
            "not_crying",
            "not_mischievous",
            "not_embarassed",
            "not_happy",
            "not_normal",
            "not_pained",
            "not_psychotic",
            "not_scared",
            "not_snooty",
            "not_smitten",
            "not_tired",
            "daytime",
            "dawn",
            "morning",
            "noon",
            "evening",
            "dusk",
            "night",
            "not_daytime",
            "not_dawn",
            "not_morning",
            "not_noon",
            "not_evening",
            "not_dusk",
            "not_night",
            "new_moon",
            "waxing_crescent_moon",
            "waxing_quarter_moon",
            "waxing_gibbous_moon",
            "full_moon",
            "waning_gibbous_moon",
            "waning_quarter_moon",
            "waning_crescent_moon",
            "not_new_moon",
            "not_waxing_crescent_moon",
            "not_waxing_quarter_moon",
            "not_waxing_gibbous_moon",
            "not_full_moon",
            "not_waning_gibbous_moon",
            "not_waning_quarter_moon",
            "not_waning_crescent_moon",
            "clear_weather",
            "rainy_weather",
            "stormy_weather",
            "snowy_weather",
            "not_clear_weather",
            "not_rainy_weather",
            "not_stormy_weather",
            "not_snowy_weather",
            "arid_climate",
            "lush_climate",
            "ocean_climate",
            "mild_climate",
            "cold_climate",
            "not_arid_climate",
            "not_lush_climate",
            "not_ocean_climate",
            "not_mild_climate",
            "not_cold_climate",
            "light_level_0",
            "light_level_1",
            "light_level_2",
            "light_level_3",
            "light_level_4",
            "light_level_5",
            "light_level_6",
            "light_level_7",
            "light_level_8",
            "light_level_9",
            "light_level_10",
            "light_level_11",
            "light_level_12",
            "light_level_13",
            "light_level_14",
            "light_level_15",
            "light_level_greater_than_0",
            "light_level_greater_than_1",
            "light_level_greater_than_2",
            "light_level_greater_than_3",
            "light_level_greater_than_4",
            "light_level_greater_than_5",
            "light_level_greater_than_6",
            "light_level_greater_than_7",
            "light_level_greater_than_8",
            "light_level_greater_than_9",
            "light_level_greater_than_10",
            "light_level_greater_than_11",
            "light_level_greater_than_12",
            "light_level_greater_than_13",
            "light_level_greater_than_14",
            "light_level_less_than_1",
            "light_level_less_than_2",
            "light_level_less_than_3",
            "light_level_less_than_4",
            "light_level_less_than_5",
            "light_level_less_than_6",
            "light_level_less_than_7",
            "light_level_less_than_8",
            "light_level_less_than_9",
            "light_level_less_than_10",
            "light_level_less_than_11",
            "light_level_less_than_12",
            "light_level_less_than_13",
            "light_level_less_than_14",
            "light_level_less_than_15",
            "y_above_0",
            "y_above_16",
            "y_above_64",
            "y_above_128",
            "y_above_256",
            "y_below_0",
            "y_below_16",
            "y_below_64",
            "y_below_128",
            "y_below_256",
            "is_nether",
            "is_overworld",
            "is_end",
            "is_christmas_soon",
            "is_christmas_today",
            "is_new_years_soon",
            "is_new_years_today",
            "is_valentines_day_soon",
            "is_valentines_day_today",
            "is_white_day_soon",
            "is_white_day_today",
            "is_summer_festival_soon",
            "is_summer_festival_today",
            "is_player_holding_equip",
            "is_player_holding_worse_equip",
            "is_player_holding_better_equip",
            "is_player_holding_gift",
            "is_player_holding_good_gift",
            "is_player_holding_bad_gift",
            "is_player_holding_food",
            "is_occupied",
            "is_sleeping",
            "is_following",
            "is_following_you",
            "is_attacking",
            "is_not_occupied",
            "is_not_sleeping",
            "is_not_following",
            "is_not_following_you",
            "is_not_attacking",
            "health_0",
            "health_2",
            "health_4",
            "health_6",
            "health_8",
            "health_10",
            "health_12",
            "health_14",
            "health_16",
            "health_18",
            "health_20",
            "health_greater_than_0",
            "health_greater_than_2",
            "health_greater_than_4",
            "health_greater_than_6",
            "health_greater_than_8",
            "health_greater_than_10",
            "health_greater_than_12",
            "health_greater_than_14",
            "health_greater_than_16",
            "health_greater_than_18",
            "health_less_than_2",
            "health_less_than_4",
            "health_less_than_6",
            "health_less_than_8",
            "health_less_than_10",
            "health_less_than_12",
            "health_less_than_14",
            "health_less_than_16",
            "health_less_than_18",
            "health_less_than_20",
            "hunger_0",
            "hunger_2",
            "hunger_4",
            "hunger_6",
            "hunger_8",
            "hunger_10",
            "hunger_12",
            "hunger_14",
            "hunger_16",
            "hunger_18",
            "hunger_20",
            "hunger_greater_than_0",
            "hunger_greater_than_2",
            "hunger_greater_than_4",
            "hunger_greater_than_6",
            "hunger_greater_than_8",
            "hunger_greater_than_10",
            "hunger_greater_than_12",
            "hunger_greater_than_14",
            "hunger_greater_than_16",
            "hunger_greater_than_18",
            "hunger_less_than_2",
            "hunger_less_than_4",
            "hunger_less_than_6",
            "hunger_less_than_8",
            "hunger_less_than_10",
            "hunger_less_than_12",
            "hunger_less_than_14",
            "hunger_less_than_16",
            "hunger_less_than_18",
            "hunger_less_than_20",
            "player_last_seen_1_day_ago",
            "player_last_seen_2_days_ago",
            "player_last_seen_3_days_ago",
            "player_last_seen_4_days_ago",
            "player_last_seen_5_days_ago",
            "player_last_seen_6_days_ago",
            "player_last_seen_7_days_ago",
            "player_last_seen_over_a_week_ago",
            "player_health_0",
            "player_health_2",
            "player_health_4",
            "player_health_6",
            "player_health_8",
            "player_health_10",
            "player_health_12",
            "player_health_14",
            "player_health_16",
            "player_health_18",
            "player_health_20",
            "player_health_greater_than_0",
            "player_health_greater_than_2",
            "player_health_greater_than_4",
            "player_health_greater_than_6",
            "player_health_greater_than_8",
            "player_health_greater_than_10",
            "player_health_greater_than_12",
            "player_health_greater_than_14",
            "player_health_greater_than_16",
            "player_health_greater_than_18",
            "player_health_less_than_2",
            "player_health_less_than_4",
            "player_health_less_than_6",
            "player_health_less_than_8",
            "player_health_less_than_10",
            "player_health_less_than_12",
            "player_health_less_than_14",
            "player_health_less_than_16",
            "player_health_less_than_18",
            "player_health_less_than_20",
            "player_hunger_0",
            "player_hunger_2",
            "player_hunger_4",
            "player_hunger_6",
            "player_hunger_8",
            "player_hunger_10",
            "player_hunger_12",
            "player_hunger_14",
            "player_hunger_16",
            "player_hunger_18",
            "player_hunger_20",
            "player_hunger_greater_than_0",
            "player_hunger_greater_than_2",
            "player_hunger_greater_than_4",
            "player_hunger_greater_than_6",
            "player_hunger_greater_than_8",
            "player_hunger_greater_than_10",
            "player_hunger_greater_than_12",
            "player_hunger_greater_than_14",
            "player_hunger_greater_than_16",
            "player_hunger_greater_than_18",
            "player_hunger_less_than_2",
            "player_hunger_less_than_4",
            "player_hunger_less_than_6",
            "player_hunger_less_than_8",
            "player_hunger_less_than_10",
            "player_hunger_less_than_12",
            "player_hunger_less_than_14",
            "player_hunger_less_than_16",
            "player_hunger_less_than_18",
            "player_hunger_less_than_20",
            "love_0",
            "love_2",
            "love_4",
            "love_6",
            "love_8",
            "love_10",
            "love_12",
            "love_14",
            "love_16",
            "love_18",
            "love_20",
            "love_greater_than_0",
            "love_greater_than_2",
            "love_greater_than_4",
            "love_greater_than_6",
            "love_greater_than_8",
            "love_greater_than_10",
            "love_greater_than_12",
            "love_greater_than_14",
            "love_greater_than_16",
            "love_greater_than_18",
            "love_less_than_0",
            "love_less_than_2",
            "love_less_than_4",
            "love_less_than_6",
            "love_less_than_8",
            "love_less_than_10",
            "love_less_than_12",
            "love_less_than_14",
            "love_less_than_16",
            "love_less_than_18",
            "love_less_than_20",
            "act_1",
            "act_2",
            "act_3",
            "act_4",
            "act_greater_than_1",
            "act_greater_than_2",
            "act_greater_than_3",
            "act_less_than_2",
            "act_less_than_3",
            "scene_1",
            "scene_2",
            "scene_3",
            "scene_4",
            "scene_5",
            "scene_6",
            "scene_7",
            "scene_8",
            "scene_9",
            "scene_greater_than_1",
            "scene_greater_than_2",
            "scene_greater_than_3",
            "scene_greater_than_4",
            "scene_greater_than_5",
            "scene_greater_than_6",
            "scene_greater_than_7",
            "scene_greater_than_8",
            "scene_less_than_2",
            "scene_less_than_3",
            "scene_less_than_4",
            "scene_less_than_5",
            "scene_less_than_6",
            "scene_less_than_7",
            "scene_less_than_8",
            "scene_less_than_9"});
            this.DialogConditionForm.Location = new System.Drawing.Point(6, 19);
            this.DialogConditionForm.Name = "DialogConditionForm";
            this.DialogConditionForm.Size = new System.Drawing.Size(275, 21);
            this.DialogConditionForm.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DialogReaction);
            this.groupBox2.Controls.Add(this.DialogEmotion);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DialogMessage);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 162);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dialog Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reaction";
            // 
            // DialogReaction
            // 
            this.DialogReaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DialogReaction.FormattingEnabled = true;
            this.DialogReaction.Items.AddRange(new object[] {
            "nothing",
            "set_love_to_0",
            "set_love_to_2",
            "set_love_to_4",
            "set_love_to_6",
            "set_love_to_8",
            "set_love_to_10",
            "set_love_to_12",
            "set_love_to_14",
            "set_love_to_16",
            "set_love_to_18",
            "set_love_to_20",
            "increment_love_by_1",
            "increment_love_by_2",
            "increment_love_by_3",
            "increment_love_by_4",
            "increment_love_by_5",
            "increment_love_by_6",
            "increment_love_by_7",
            "increment_love_by_8",
            "increment_love_by_9",
            "increment_love_by_10",
            "decrement_love_by_1",
            "decrement_love_by_2",
            "decrement_love_by_3",
            "decrement_love_by_4",
            "decrement_love_by_5",
            "decrement_love_by_6",
            "decrement_love_by_7",
            "decrement_love_by_8",
            "decrement_love_by_9",
            "decrement_love_by_10",
            "set_act_to_1",
            "set_act_to_2",
            "set_act_to_3",
            "set_act_to_4",
            "next_act",
            "previous_act",
            "set_scene_to_1",
            "set_scene_to_2",
            "set_scene_to_3",
            "set_scene_to_4",
            "set_scene_to_5",
            "set_scene_to_6",
            "set_scene_to_7",
            "set_scene_to_8",
            "set_scene_to_9",
            "next_scene",
            "previous_scene",
            "offer_onigiri",
            "offer_cupcake",
            "offer_love_letter",
            "offer_gift_bag",
            "offer_food_item",
            "offer_drop_item",
            "give_gift_item",
            "drop_gift_item",
            "eat_gift_item",
            "keep_gift_item",
            "follow_player",
            "stop_following_player",
            "kill_friend",
            "kill_rival",
            "kill_player",
            "kill_random",
            "kill_self",
            "special_action",
            "set_health_to_0",
            "set_health_to_2",
            "set_health_to_4",
            "set_health_to_6",
            "set_health_to_8",
            "set_health_to_10",
            "set_health_to_12",
            "set_health_to_14",
            "set_health_to_16",
            "set_health_to_18",
            "set_health_to_20",
            "increment_health_by_1",
            "increment_health_by_2",
            "increment_health_by_3",
            "increment_health_by_4",
            "increment_health_by_5",
            "increment_health_by_6",
            "increment_health_by_7",
            "increment_health_by_8",
            "increment_health_by_9",
            "increment_health_by_10",
            "decrement_health_by_1",
            "decrement_health_by_2",
            "decrement_health_by_3",
            "decrement_health_by_4",
            "decrement_health_by_5",
            "decrement_health_by_6",
            "decrement_health_by_7",
            "decrement_health_by_8",
            "decrement_health_by_9",
            "decrement_health_by_10",
            "set_hunger_to_0",
            "set_hunger_to_2",
            "set_hunger_to_4",
            "set_hunger_to_6",
            "set_hunger_to_8",
            "set_hunger_to_10",
            "set_hunger_to_12",
            "set_hunger_to_14",
            "set_hunger_to_16",
            "set_hunger_to_18",
            "set_hunger_to_20",
            "increment_hunger_by_1",
            "increment_hunger_by_2",
            "increment_hunger_by_3",
            "increment_hunger_by_4",
            "increment_hunger_by_5",
            "increment_hunger_by_6",
            "increment_hunger_by_7",
            "increment_hunger_by_8",
            "increment_hunger_by_9",
            "increment_hunger_by_10",
            "decrement_hunger_by_1",
            "decrement_hunger_by_2",
            "decrement_hunger_by_3",
            "decrement_hunger_by_4",
            "decrement_hunger_by_5",
            "decrement_hunger_by_6",
            "decrement_hunger_by_7",
            "decrement_hunger_by_8",
            "decrement_hunger_by_9",
            "decrement_hunger_by_10",
            "set_player_health_to_0",
            "set_player_health_to_2",
            "set_player_health_to_4",
            "set_player_health_to_6",
            "set_player_health_to_8",
            "set_player_health_to_10",
            "set_player_health_to_12",
            "set_player_health_to_14",
            "set_player_health_to_16",
            "set_player_health_to_18",
            "set_player_health_to_20",
            "increment_player_health_by_1",
            "increment_player_health_by_2",
            "increment_player_health_by_3",
            "increment_player_health_by_4",
            "increment_player_health_by_5",
            "increment_player_health_by_6",
            "increment_player_health_by_7",
            "increment_player_health_by_8",
            "increment_player_health_by_9",
            "increment_player_health_by_10",
            "decrement_player_health_by_1",
            "decrement_player_health_by_2",
            "decrement_player_health_by_3",
            "decrement_player_health_by_4",
            "decrement_player_health_by_5",
            "decrement_player_health_by_6",
            "decrement_player_health_by_7",
            "decrement_player_health_by_8",
            "decrement_player_health_by_9",
            "decrement_player_health_by_10",
            "set_player_hunger_to_0",
            "set_player_hunger_to_2",
            "set_player_hunger_to_4",
            "set_player_hunger_to_6",
            "set_player_hunger_to_8",
            "set_player_hunger_to_10",
            "set_player_hunger_to_12",
            "set_player_hunger_to_14",
            "set_player_hunger_to_16",
            "set_player_hunger_to_18",
            "set_player_hunger_to_20",
            "increment_player_hunger_by_1",
            "increment_player_hunger_by_2",
            "increment_player_hunger_by_3",
            "increment_player_hunger_by_4",
            "increment_player_hunger_by_5",
            "increment_player_hunger_by_6",
            "increment_player_hunger_by_7",
            "increment_player_hunger_by_8",
            "increment_player_hunger_by_9",
            "increment_player_hunger_by_10",
            "decrement_player_hunger_by_1",
            "decrement_player_hunger_by_2",
            "decrement_player_hunger_by_3",
            "decrement_player_hunger_by_4",
            "decrement_player_hunger_by_5",
            "decrement_player_hunger_by_6",
            "decrement_player_hunger_by_7",
            "decrement_player_hunger_by_8",
            "decrement_player_hunger_by_9",
            "decrement_player_hunger_by_10"});
            this.DialogReaction.Location = new System.Drawing.Point(62, 134);
            this.DialogReaction.Name = "DialogReaction";
            this.DialogReaction.Size = new System.Drawing.Size(300, 21);
            this.DialogReaction.TabIndex = 3;
            // 
            // DialogEmotion
            // 
            this.DialogEmotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DialogEmotion.FormattingEnabled = true;
            this.DialogEmotion.Items.AddRange(new object[] {
            "angry",
            "begging",
            "confused",
            "crying",
            "mischievous",
            "embarassed",
            "happy",
            "normal",
            "pained",
            "psychotic",
            "scared",
            "sick",
            "snooty",
            "smitten",
            "tired"});
            this.DialogEmotion.Location = new System.Drawing.Point(62, 107);
            this.DialogEmotion.Name = "DialogEmotion";
            this.DialogEmotion.Size = new System.Drawing.Size(300, 21);
            this.DialogEmotion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Emotion";
            // 
            // DialogMessage
            // 
            this.DialogMessage.Location = new System.Drawing.Point(6, 19);
            this.DialogMessage.Multiline = true;
            this.DialogMessage.Name = "DialogMessage";
            this.DialogMessage.Size = new System.Drawing.Size(356, 82);
            this.DialogMessage.TabIndex = 0;
            // 
            // DialogClose
            // 
            this.DialogClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DialogClose.Location = new System.Drawing.Point(305, 349);
            this.DialogClose.Name = "DialogClose";
            this.DialogClose.Size = new System.Drawing.Size(75, 23);
            this.DialogClose.TabIndex = 2;
            this.DialogClose.Text = "Cancel";
            this.DialogClose.UseVisualStyleBackColor = true;
            // 
            // DialogSave
            // 
            this.DialogSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DialogSave.Location = new System.Drawing.Point(224, 349);
            this.DialogSave.Name = "DialogSave";
            this.DialogSave.Size = new System.Drawing.Size(75, 23);
            this.DialogSave.TabIndex = 3;
            this.DialogSave.Text = "Save";
            this.DialogSave.UseVisualStyleBackColor = true;
            // 
            // DialogDataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.DialogClose;
            this.ClientSize = new System.Drawing.Size(392, 383);
            this.Controls.Add(this.DialogSave);
            this.Controls.Add(this.DialogClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogDataEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Dialog";
            this.Load += new System.EventHandler(this.DialogDataEditor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ConditionContextMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox DialogConditionForm;
        private System.Windows.Forms.ListBox DialogConditions;
        private System.Windows.Forms.Button DialogConditonSubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox DialogEmotion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DialogMessage;
        private System.Windows.Forms.ComboBox DialogTrigger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox DialogReaction;
        private System.Windows.Forms.Button DialogClose;
        private System.Windows.Forms.Button DialogSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip ConditionContextMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteCondition;
    }
}