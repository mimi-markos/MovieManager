using System;
using System.Net;
using System.ComponentModel.DataAnnotations;

namespace MMS.Data.Validators {

    // Custom Validator 
    public class UrlResource : ValidationAttribute {
    
        protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
            // url property being validated should be a string;   
            string _url = (string)value;         

            // verify the url points to a resource
            if (UrlResourceExists(_url)) 
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Url is not valid");        
        }
        
        // verify that url points to a valid resource
        private bool UrlResourceExists(string url) { 
            if (url == null)
            {
                return true;
            }                            
            // method HEAD verifies resource existence
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = "HEAD";
            try {
                webRequest.GetResponse();
                return true;  // got here so valid
            } catch {
                return false; // exception thrown so invalid
            }
        }
    }
}
