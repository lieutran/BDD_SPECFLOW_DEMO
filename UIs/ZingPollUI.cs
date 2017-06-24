using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD_SPECFLOW_DEMO.UIs
{
    class ZingPollUI
    {
        public static string HOMEPAGE_URL = "https://www.zingpoll.com";
        public static string SIGN_IN_TITLE = "//*[@id='Loginform']";
        public static string SIGN_IN_POPUP = "//*[@id='Login']//div[@class='modal-content']";
        public static string ERROR_NOT_REGISTERED_MESSAGE = "//*[@id='loginMessage' and contains(text(),'{0}')]";
        public static string PASSWORD_INCORECT_ERROR_MESSAGE = "//*[@id='loginMessageFail' and contains(text(),'{0}')]";
        public static string EMAIL_TEXTBOX = "//*[@id='loginEmail']";
        public static string PASSWORD_TEXTBOX = "//*[@id='loginPassword']";
        public static string LOGIN_BUTTON = "//*[@id='button-login']";
        public static string PROFILE_NAME_TITLE = "//div[@class='username' and contains(text(),'{0}')]";
    }
}
