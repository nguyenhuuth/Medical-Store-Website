﻿using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace MedicalStore.Utils.Common
{
    public class ServerApiResponse<T>
    {
        public T data;
        public IDictionary<string, string> details;

        public ServerApiResponse()
        {
            this.details = new Dictionary<string, string>();
        }

        public void setMessage(string key)
        {
            Console.WriteLine("---------" + key);
            this.details.Add("message", key);
        }

        public void setMessage(string key, string field)
        {
            string value = ValidatorOptions.Global.LanguageManager.GetString(key);
            this.details.Add(field, value);
        }

        public void setErrorMessage(string errorKey)
        {
            ValidationResult result = new ValidationResult();
            var failure = new ValidationFailure("errorMessage", errorKey);
            failure.FormattedMessagePlaceholderValues = new Dictionary<string, object>();
            failure.FormattedMessagePlaceholderValues.Add("field", "errorMessage");

            result.Errors.Add(failure);
            mapDetails(result);
        }

        public void setErrorMessage(string errorKey, string field)
        {
            ValidationResult result = new ValidationResult();
            var failure = new ValidationFailure(field, errorKey);
            failure.FormattedMessagePlaceholderValues = new Dictionary<string, object>();
            failure.FormattedMessagePlaceholderValues.Add("field", field);

            result.Errors.Add(failure);
            mapDetails(result);
        }

        // Set error message with context, default field is "errorMessage"
        public void setErrorMessage(string errorKey, Dictionary<string, object> context)
        {
            ValidationResult result = new ValidationResult();
            string errorMessage = ValidatorOptions.Global.LanguageManager.GetString(errorKey);
            var failure = new ValidationFailure("errorMessage", errorMessage);
            failure.FormattedMessagePlaceholderValues = context;

            result.Errors.Add(failure);
            mapDetails(result);
        }

        //Set errorMessage with full option :)
        public void setErrorMessage(string errorKey, Dictionary<string, object> context, string field = "errorMessage")
        {
            ValidationResult result = new ValidationResult();
            string errorMessage = ValidatorOptions.Global.LanguageManager.GetString(errorKey);
            var failure = new ValidationFailure(field, errorMessage);
            failure.FormattedMessagePlaceholderValues = context;
            failure.FormattedMessagePlaceholderValues.Add("field", field);

            result.Errors.Add(failure);
            mapDetails(result);
        }

        public void mapDetails(ValidationResult result)
        {
            IDictionary<string, string> details = new Dictionary<string, string>();


            foreach (var failure in result.Errors)
            {
                string value = "";
                bool isExisted = details.TryGetValue(failure.PropertyName, out value);
                if (!isExisted)
                {
                    string field = failure.PropertyName;
                    string message = Helper.StringFormat(failure.ErrorMessage, failure.FormattedMessagePlaceholderValues);
                    details.Add(field, message);
                }
            }

            this.details = details;
        }


        public IDictionary<string, Object> getResponse()
        {
            IDictionary<string, Object> res = new Dictionary<string, Object>();

            if (this.data == null)
            {
                res.Add("data", null);
            }
            else
            {
                res.Add("data", this.data);
            }

            res.Add("details", this.details);
            return res;
        }
    }
}
