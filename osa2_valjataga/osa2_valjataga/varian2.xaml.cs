﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace osa2_valjataga
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class varian2 : ContentPage
    {
        /*
        DatePicker dateP;
        Editor edi, sign;
        Image img;
        DateTime aries = new DateTime(21 / 03);
        DateTime ariesend = new DateTime(19 / 04);
        System.DateTime moment = new System.DateTime();
        DatePicker datePicker;
        Image image;
        Entry etryyy;
        */
        DateTime changetime_date;
        public varian2()
        {
            InitializeComponent();
            Grid grd = new Grid();

            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            grd.ColumnDefinitions.Add(colDef1);
            grd.ColumnDefinitions.Add(colDef2);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            grd.RowDefinitions.Add(rowDef1);
            grd.RowDefinitions.Add(rowDef2);
        }

        private void datatime_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            changetime_date = datatime.Date;
            if (changetime_date.Month.ToString() == "1")
            {
                img.Source = "kozerog.png";
                label1.Text = "Козерог";
                label2.Text = "Знак земной стихии, Козерог обладает даром не терять из виду главную цель и долго жить. Целеустремленность, стойкость в трудностях, ответственность — это сильные качества представителей этого знака.";
            }
            if (changetime_date.Month.ToString() == "2")
            {
                img.Source = "vodolei.png";
                label1.Text = "Водолей";
                label2.Text = "Водолей наделен творческой энергией, оптимизмом и развитой интуицией. Часто обладают привлекательной внешностью и интеллектуально одарены. Сильная впечатлительность, умение завязывать приятельские отношения и нужные связи, оригинальные идеи и взгляд на мир, делают Водолея незаменимым другом и единомышленником.";
            }
            if (changetime_date.Month.ToString() == "3")
            {
                img.Source = "riba.png";
                label1.Text = "Рыбы";
                label2.Text = "У Рыб легкий, приятный характер, слегка окрашенный в романтические или меланхолические тона. Представители знака не отличаются большой жизненной энергией или выдающимся стоицизмом и предпочитают пережидать трудные времена за чьими-нибудь широкими плечами, но на это никто не жалуется. У Рыб огромный запас душевного тепла, поэтому они способны растопить даже ледяное сердце.";
            }
            if (changetime_date.Month.ToString() == "4")
            {
                img.Source = "oven.png";
                label1.Text = "Овен";
                label2.Text = "Под этим знаком появляются на свет неутомимые борцы и неисправимые оптимисты. Их упрямство достойно войти в пословицы. Чего Овны не любят – так это слишком долго заниматься одним делом: уж слишком быстро они «перегорают». И в любви все так же: вспышка страсти, головокружительный роман, а затем – охлаждение и поиски нового партнера.";
            }
            if (changetime_date.Month.ToString() == "5")
            {
                img.Source = "telets.png";
                label1.Text = "Телец";
                label2.Text = "Тельцы совершенно уверены, что появились на свет для того, чтобы сделать мир лучше, и в этом они почти не ошибаются. Способность Тельцов украшать и приукрашивать удивительна. Там, где за дело берутся представители этого знака, вскоре не остается ничего, что бы не радовало глаз и не поднимало настроения. Но доброжелательные Тельцы становятся совершенно безжалостными, когда кто-то пытается обидеть их близких";
            }
            if (changetime_date.Month.ToString() == "6")
            {
                img.Source = "bliznisi.png";
                label1.Text = "Близнецы";
                label2.Text = "Близнецы многолики, переменчивы и непредсказуемы. С ними всегда весело и интересно, но очень редко бывает спокойно. Рутина – главный враг Близнецов, над которыми они регулярно одерживают верх. Представители знака наделены незаурядными артистическими талантами. Если Близнецы случайно не работают в театре, значит, в театр превратится вся их жизнь.";
            }
            if (changetime_date.Month.ToString() == "7")
            {
                img.Source = "rak.jpg";
                label1.Text = "Рак";
                label2.Text = "Стихия Раков – душевные порывы, тонкие переживания, высокие чувства. Все грубое и материальное представляется им малоинтересным; исключением являются деньги и красивые вещи – против них Раки ничего не имеют. Семья для Раков – всегда приоритет. О благополучии своих близких представители знака позаботятся в любых обстоятельствах.";
            }
            if (changetime_date.Month.ToString() == "8")
            {
                img.Source = "lev.png";
                label1.Text = "Лев";
                label2.Text = "Львов невозможно не заметить: везде, где появляются представители знака, они оказываются в центре внимания. От простых смертных Львов отличает безупречный вкус, а также искренняя (и взаимная) любовь к роскоши. Можно не любить Льва, но не любоваться им невозможно. Неожиданностью для многих оказывается то, что за яркой внешностью скрывается ранимая душа.";
            }
            if (changetime_date.Month.ToString() == "9")
            {
                img.Source = "deva.png";
                label1.Text = "Дева";
                label2.Text = "Считается, что именно под знаком Девы появляются на свет самые умные люди. Они не только отличаются незаурядным интеллектом, но и умеют сказать твердое и решительное «нет» тем чувствам и эмоциям, которые считают ненужными. Дева способна создать прочную и счастливую семью, но едва ли будет чувствовать себя несчастной, если останется в одиночестве: представители знака самодостаточны.";
            }
            if (changetime_date.Month.ToString() == "10")
            {
                img.Source = "vesi.png";
                label1.Text = "Весы";
                label2.Text = "Считается, что Весы нерешительны, но это совсем не так. Они просто принимают во внимание многие факторы – в том числе те, которых не замечают представители других знаков, и именно поэтому часто проводят время в размышлениях. Кроме того, представители знака отличаются хорошими манерами, дружелюбием и оптимизмом. Только очень терпеливый и настойчивый человек способен испортить Весам настроение.";
            }
            if (changetime_date.Month.ToString() == "11")
            {
                img.Source = "skorpion.png";
                label1.Text = "Скорпион";
                label2.Text = "Скорпион незаменим в тех случаях, когда другие сдались. Он обладает стойкостью духа и физической выносливостью. Знак постоянного креста, Скорпион любит доводить начатое до конца, трудолюбивый и целеустремленный человек. Любит власть и деньги. Всегда дожидается своего звездного часа, когда сможет действовать во всю мощь. Терпелив, когда ему это необходимо. Скорпиона трудно понять с первого взгляда, поверхностного общения будет недостаточно, чтобы постичь его глубокую эмоциональность.";
            }
            if (changetime_date.Month.ToString() == "12")
            {
                img.Source = "strelets.png";
                label1.Text = "Стрелец";
                label2.Text = "Стрельцов природа наделила жизнерадостной натурой и стойкостью. Эти черты помогают им преодолевать трудности, не падая духом от неудач. Стрельцы всегда открыты навстречу новому, не страшатся перемен — они уверены, что дальше будет только интереснее..";
            }
        }

        private void entri_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (entri.Text.ToLower() == "козерог")
            {
                img.Source = "kozerog.png";
                label1.Text = "Козерог";
                label2.Text = "Знак земной стихии, Козерог обладает даром не терять из виду главную цель и долго жить. Целеустремленность, стойкость в трудностях, ответственность — это сильные качества представителей этого знака.";
            }
            if (entri.Text.ToLower() == "водолей")
            {
                img.Source = "vodolei.png";
                label1.Text = "Водолей";
                label2.Text = "Водолей наделен творческой энергией, оптимизмом и развитой интуицией. Часто обладают привлекательной внешностью и интеллектуально одарены. Сильная впечатлительность, умение завязывать приятельские отношения и нужные связи, оригинальные идеи и взгляд на мир, делают Водолея незаменимым другом и единомышленником.";
            }
            if (entri.Text.ToLower() == "рыбы")
            {
                img.Source = "riba.png";
                label1.Text = "Рыбы";
                label2.Text = "У Рыб легкий, приятный характер, слегка окрашенный в романтические или меланхолические тона. Представители знака не отличаются большой жизненной энергией или выдающимся стоицизмом и предпочитают пережидать трудные времена за чьими-нибудь широкими плечами, но на это никто не жалуется. У Рыб огромный запас душевного тепла, поэтому они способны растопить даже ледяное сердце.";
            }
            if (entri.Text.ToLower() == "овен")
            {
                img.Source = "oven.png";
                label1.Text = "Овен";
                label2.Text = "Под этим знаком появляются на свет неутомимые борцы и неисправимые оптимисты. Их упрямство достойно войти в пословицы. Чего Овны не любят – так это слишком долго заниматься одним делом: уж слишком быстро они «перегорают». И в любви все так же: вспышка страсти, головокружительный роман, а затем – охлаждение и поиски нового партнера.";
            }
            if (entri.Text.ToLower() == "телец")
            {
                img.Source = "telets.png";
                label1.Text = "Телец";
                label2.Text = "Тельцы совершенно уверены, что появились на свет для того, чтобы сделать мир лучше, и в этом они почти не ошибаются. Способность Тельцов украшать и приукрашивать удивительна. Там, где за дело берутся представители этого знака, вскоре не остается ничего, что бы не радовало глаз и не поднимало настроения. Но доброжелательные Тельцы становятся совершенно безжалостными, когда кто-то пытается обидеть их близких";
            }
            if (entri.Text.ToLower() == "близнецы")
            {
                img.Source = "bliznisi.png";
                label1.Text = "Близнецы";
                label2.Text = "Близнецы многолики, переменчивы и непредсказуемы. С ними всегда весело и интересно, но очень редко бывает спокойно. Рутина – главный враг Близнецов, над которыми они регулярно одерживают верх. Представители знака наделены незаурядными артистическими талантами. Если Близнецы случайно не работают в театре, значит, в театр превратится вся их жизнь.";
            }
            if (entri.Text.ToLower() == "рак")
            {
                img.Source = "rak.jpg";
                label1.Text = "Рак";
                label2.Text = "Стихия Раков – душевные порывы, тонкие переживания, высокие чувства. Все грубое и материальное представляется им малоинтересным; исключением являются деньги и красивые вещи – против них Раки ничего не имеют. Семья для Раков – всегда приоритет. О благополучии своих близких представители знака позаботятся в любых обстоятельствах.";
            }
            if (entri.Text.ToLower() == "лев")
            {
                img.Source = "lev.png";
                label1.Text = "Лев";
                label2.Text = "Львов невозможно не заметить: везде, где появляются представители знака, они оказываются в центре внимания. От простых смертных Львов отличает безупречный вкус, а также искренняя (и взаимная) любовь к роскоши. Можно не любить Льва, но не любоваться им невозможно. Неожиданностью для многих оказывается то, что за яркой внешностью скрывается ранимая душа.";
            }
            if (entri.Text.ToLower() == "дева")
            {
                img.Source = "deva.png";
                label1.Text = "Дева";
                label2.Text = "Считается, что именно под знаком Девы появляются на свет самые умные люди. Они не только отличаются незаурядным интеллектом, но и умеют сказать твердое и решительное «нет» тем чувствам и эмоциям, которые считают ненужными. Дева способна создать прочную и счастливую семью, но едва ли будет чувствовать себя несчастной, если останется в одиночестве: представители знака самодостаточны.";
            }
            if (entri.Text.ToLower() == "весы")
            {
                img.Source = "vesi.png";
                label1.Text = "Весы";
                label2.Text = "Считается, что Весы нерешительны, но это совсем не так. Они просто принимают во внимание многие факторы – в том числе те, которых не замечают представители других знаков, и именно поэтому часто проводят время в размышлениях. Кроме того, представители знака отличаются хорошими манерами, дружелюбием и оптимизмом. Только очень терпеливый и настойчивый человек способен испортить Весам настроение.";
            }
            if (entri.Text.ToLower() == "скорпион")
            {
                img.Source = "skorpion.png";
                label1.Text = "Скорпион";
                label2.Text = "Скорпион незаменим в тех случаях, когда другие сдались. Он обладает стойкостью духа и физической выносливостью. Знак постоянного креста, Скорпион любит доводить начатое до конца, трудолюбивый и целеустремленный человек. Любит власть и деньги. Всегда дожидается своего звездного часа, когда сможет действовать во всю мощь. Терпелив, когда ему это необходимо. Скорпиона трудно понять с первого взгляда, поверхностного общения будет недостаточно, чтобы постичь его глубокую эмоциональность.";
            }
            if (entri.Text.ToLower() == "стрелец")
            {
                img.Source = "strelets.png";
                label1.Text = "Стрелец";
                label2.Text = "Стрельцов природа наделила жизнерадостной натурой и стойкостью. Эти черты помогают им преодолевать трудности, не падая духом от неудач. Стрельцы всегда открыты навстречу новому, не страшатся перемен — они уверены, что дальше будет только интереснее..";
            }
        }
    }
}
        