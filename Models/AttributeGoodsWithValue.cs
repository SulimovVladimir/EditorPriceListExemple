﻿using System.ComponentModel.DataAnnotations;

namespace EditorPriceListExemple.Models
{
    public class AttributeGoodsWithValue
    {
        [Key]
        public int RecordAttributeGoodsID { get; set; }
        public int GoodsID { get; set; }
        public Goods Goods { get; set; }
        public int AttributeGoodsID { get; set; }
        public AttributeGoods AttributeGoods { get; set; }
        public string Value { get; set; }
    }
}
