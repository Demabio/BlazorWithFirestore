using System;
using System.Collections.Generic;
using System.Text;
using System;
using Google.Cloud.Firestore;

namespace BlazorWithFirestore3.Shared.Models
{
    [FirestoreData]
    public class Cities
    {
        public string CityName { get; set; }
    }
}
