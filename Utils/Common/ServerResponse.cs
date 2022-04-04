using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MedicalStore.Utils.Common
{
    public class ServerResponse
    {
        public static void SetFieldErrorMessage(string field, string key, ViewDataDictionary dataView)
        {
            dataView[$"{field}Error"] = key;
        }

        public static void SetMessage(string key, ViewDataDictionary dataView)
        {
            string value = ValidatorOptions.Global.LanguageManager.GetString(key);
            dataView["message"] = value;
        }

        public static void SetErrorMessage(string errorKey, ViewDataDictionary dataView)
        {
            dataView["errorMessage"] = errorKey;
        }

        public string getRedirectWithMessage(string link, string message, string errorMessage)
        {

            return $"{link}?message={message}&errorMessage={errorMessage}";
        }


        public static void MapDetails(ValidationResult result, ViewDataDictionary dataView)
        {
            foreach (var failure in result.Errors)
            {
                string field = failure.PropertyName;
                string message = Helper.StringFormat(failure.ErrorMessage, failure.FormattedMessagePlaceholderValues);
                dataView[$"{field}Error"] = message;
            }
        }
    }
}
