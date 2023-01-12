﻿using Dog_Grooming_App.Models;
namespace Dog_Grooming_App;

public partial class Services : ContentPage
{

    public List<Service> services { get; set; }


    public Services()
    {
        InitializeComponent();
        services = new List<Service>
            {
                new Service { Name = "Baie și tundere",  Image = "dogwash.png", Details = "Include baia cu șampon special pentru câini, tunderea blănii și periajul. ", Price = 40 },
                new Service { Name = "Manichiura",  Image = "dogmanicure.png", Details = "Include tăierea unghiilor câinilor și periajul. ", Price =  30 },
                new Service { Name = "Periaj",  Image = "dogbrush.png", Details = "Include periaj pentru câini cu perie specială. ", Price = 20 },
                new Service { Name = "Vopsire",  Image = "dogpaint.png", Details = "Include vopsirea blănii câinilor cu vopsea specială pentru câini.", Price = 35 }
    };
        BindingContext = this;
    }

}