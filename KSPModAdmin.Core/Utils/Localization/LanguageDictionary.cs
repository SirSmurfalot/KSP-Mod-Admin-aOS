using System.Collections.Generic;

namespace KSPModAdmin.Core.Utils.Localization
{
    /// <summary>
    /// A Dictionary for language key value pairs.
    /// </summary>
    public class LanguagesDictionary : Dictionary<string, Dictionary<string, string>>
    {
        #region Properties

        /// <summary>
        /// Indexer to get a value of a language for a certain key.
        /// </summary>
        /// <returns>The value of a language for a certain key.</returns>
        public string this[string language, string key]
        {
            get
            {
                return this[language][key];
            }
            set
            {
                if (!this.ContainsKey(language))
                    this.Add(language, new Dictionary<string, string>());

                if (!this[language].ContainsKey(key))
                    this[language].Add(key, value);
                else
                    this[language][key] = value;
            }
        }

        #endregion

        /// <summary>
        /// Checks if the language is loaded by the Localizer.
        /// </summary>
        /// <param name="language">The language to check.</param>he tree path
        /// <returns>True if dictionary contains the passed language.</returns>
        public bool ContainsLaguage(string language)
        {
            return this.ContainsKey(language);
        }

        /// <summary>
        /// Checks if the key is set for the specified language.
        /// </summary>
        /// <param name="language">The language to check.</param>
        /// <param name="key">The key to search for.</param>
        /// <returns>True if dictionary contains the passed key for the passed language.</returns>
        public bool ContainsKey(string language, string key)
        {
            return this.ContainsLaguage(language) && this[language].ContainsKey(key);
        }


        /// <summary>
        /// Adds a key value pair for a certain language.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void Add(string language, string key, string value)
        {
            if (!ContainsLaguage(language))
                this.Add(language, new Dictionary<string, string>());

            this[language].Add(key, value);
        }


        /// <summary>
        /// Adds a key value pair for a certain language.
        /// </summary>
        /// <param name="language">The language to remove.</param>
        public void RemoveLanguage(string language)
        {
            if (ContainsLaguage(language))
                this.Remove(language);
        }

        /// <summary>
        /// Adds a key value pair for a certain language.
        /// </summary>
        /// <param name="language">The language.</param>
        /// <param name="key">The key to remove.</param>
        public void RemoveKeyFromLanguage(string language, string key)
        {
            if (ContainsLaguage(language))
                this[language].Remove(key);
        }
    }
}