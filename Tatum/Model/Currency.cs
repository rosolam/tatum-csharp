﻿using System;

namespace Tatum.Model
{
    public enum Currency
    {
        [EnumString("BTC")]
        BTC,

        [EnumString("BCH")]
        BCH,

        [EnumString("LTC")]
        LTC,

        [EnumString("ETH")]
        ETH,

        [EnumString("XRP")]
        XRP,

        [EnumString("XLM")]
        XLM,

        [EnumString("VET")]
        VET,

        [EnumString("NEO")]
        NEO,

        [EnumString("BNB")]
        BNB,

        [EnumString("USDT")]
        USDT,

        [EnumString("LEO")]
        LEO,

        [EnumString("LINK")]
        LINK,

        [EnumString("UNI")]
        UNI,

        [EnumString("FREE")]
        FREE,

        [EnumString("MKR")]
        MKR,

        [EnumString("USDC")]
        USDC,

        [EnumString("BAT")]
        BAT,

        [EnumString("TUSD")]
        TUSD,

        [EnumString("PAX")]
        PAX,

        [EnumString("PLTC")]
        PLTC,

        [EnumString("XCON")]
        XCON,

        [EnumString("MMY")]
        MMY,

        [EnumString("PAXG")]
        PAXG,

        [EnumString("QTUM")]
        QTUM,

        [EnumString("BSC")]
        BSC,

        [EnumString("MATIC")]
        MATIC,

        [EnumString("XDC")]
        XDC,

        [EnumString("ONE")]
        ONE,

        [EnumString("CELO")]
        CELO,

        [EnumString("DOGE")]
        DOGE

    }

    public static class CurrencyExtensions
    {
        public static string GetEnumString(this Currency currency)
        {
            var enumType = currency.GetType();
            var enumName = Enum.GetName(enumType, currency);
            if (enumName != null)
            {
                var field = enumType.GetField(enumName);

                return (Attribute.GetCustomAttribute(field, typeof(EnumStringAttribute)) as EnumStringAttribute).EnumString;
            }

            return null;
        }
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EnumStringAttribute : Attribute
    {
        public EnumStringAttribute(string enumString)
        {
            EnumString = enumString;
        }
        public string EnumString { get; private set; }
    }
}
