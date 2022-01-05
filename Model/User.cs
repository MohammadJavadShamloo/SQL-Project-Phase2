using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Data.SqlClient;
using System.Data;

namespace Model
{
    public class User
    {
        public int user_id { get; set; }
        public Boolean gender { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string telephone { get; set; }
        public string national_id { get; set; }
        public DateTime birth_data { get; set; }
        public string email { get; set; }
        public string mobile_phone { get; set; }
        public string account_number { get; set; }
        public string card_number { get; set; }
        public string shaba_number { get; set; }
        public double balance { get; set; }

        public User() { }

        public User(int user_id, bool gender, string first_name, string last_name, string telephone, string national_id, DateTime birth_data, string email, string mobile_phone, string account_number, string card_number, string shaba_number, double balance)
        {
            this.user_id = user_id;
            this.gender = gender;
            this.first_name = first_name;
            this.last_name = last_name;
            this.telephone = telephone;
            this.national_id = national_id;
            this.birth_data = birth_data;
            this.email = email;
            this.mobile_phone = mobile_phone;
            this.account_number = account_number;
            this.card_number = card_number;
            this.shaba_number = shaba_number;
            this.balance = balance;
        }

        public override string ToString() => user_id + "\t" + gender + "\t" + first_name + "\t" + last_name + "\t" + national_id + "\t" + birth_data + "\t" + mobile_phone + "\t" + account_number + "\t" + card_number + "\t" + shaba_number + "\t" + balance;

    }
}
