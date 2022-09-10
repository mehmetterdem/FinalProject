﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Constant
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi gecersiz";
        public static string MaintenanceTime = "Sistem bakım zamanı";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategory="Bir kategoride en fazla 10 ürün bulunabilir";
        internal static string ProductNameAlreadyExists="Ürün ismi mevcut ";
        internal static string CategoryLimiteExceded="Kategori limiti aşıldığı için yeni kategori eklenemiyor";
    }
}
