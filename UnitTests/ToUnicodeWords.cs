﻿using NumericWordsConversion;
using NUnit.Framework;

namespace UnitTests
{

    using System;

    public class ToUnicodeWords
    {
        public CurrencyWordsConverter amtToWords { get; set; }

        [SetUp]
        public void Setup()
        {
            this.amtToWords = new CurrencyWordsConverter(new CurrencyWordsConversionOptions
            {
                Culture = Culture.Nepali,
                OutputFormat = OutputFormat.Unicode,
            });
        }

        [Test]
        public void ZeroPaisa()
        {
            var actualResult = this.amtToWords.ToWords(32152M);
            const String expectedResult = "बतीस हजार एक सय बाउन्न रूपैयाँ मात्र";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void OnePaisa()
        {
            var actualResult = this.amtToWords.ToWords(32152.01M);
            const String expectedResult = "बतीस हजार एक सय बाउन्न रूपैयाँ एक पैसा मात्र";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void TenPaisa()
        {
            var actualResult = this.amtToWords.ToWords(32152.10M);
            const String expectedResult = "बतीस हजार एक सय बाउन्न रूपैयाँ दस पैसा मात्र";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ElevenPaisa()
        {
            var actualResult = this.amtToWords.ToWords(32152.11M);
            const String expectedResult = "बतीस हजार एक सय बाउन्न रूपैयाँ एघार पैसा मात्र";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ThirtyPaisa()
        {
            var actualResult = this.amtToWords.ToWords(32152.30M);
            const String expectedResult = "बतीस हजार एक सय बाउन्न रूपैयाँ तीस पैसा मात्र";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void EightyEightPaisa()
        {
            var actualResult = this.amtToWords.ToWords(32152.88M);
            const String expectedResult = "बतीस हजार एक सय बाउन्न रूपैयाँ अठासी पैसा मात्र";
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
