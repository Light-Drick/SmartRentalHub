using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartRentalHub
{
    internal static class FirestoreHelper
    {
        static string fireconfig = @"
        {
          ""type"": ""service_account"",
          ""project_id"": ""smartrental-hub"",
          ""private_key_id"": ""183d2f1612eb95cb29de03afe91f32c6853e1cb6"",
          ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQCM9wRdUuDBGKsn\nSmgTpdZyiRLk6HeyIVIJglZQ/t79LnMQlvKudfBPFyA95yrm+w+AqUFH17rtihXL\narMRuzk9SeKkeaZLu6/1uC/4sMk0mUG+OzLHHJMEMpPOPl7YxbV+4XuGINS/HU68\nk8eZIVpeldBDmFA7NIF47ZK1JkkQBmEEPQmvVASD5Wef8H9ysSFM5Uyk5hX4v+Rm\nq/ceJjYHgrfsEq/A/DIy0vyO3Uacw/9lwZ20pKMsaPk1rrMdbICKgHqefDM3NBmB\nCXbmT1I3N6EnoQAfo3u7zVhCoT1eqZO5m9vn9Qk2SaTPvE1PbbVvTMElrbXNHvC8\nRe579HPDAgMBAAECggEACzSJfsebQQ4ucLmb60/n64PU4ihOd3TpmgLnzJlt7U83\na06sbMzINOlAMVuCUAkN8urBWy4dWEt9LwXExTiONL5+Sxe2bde2BYDGI20eGVXD\nYZVAFI7DavaAREk17eJNapAO6xsJ/kUcoKXYnGYH0nPzMaRWYFZsokm0Oz0XWrQg\n4jZT733vjbeGKb5R7kLrCxGAdT03is0+xRfKrvoTSdw/7/ZuhXNMCuKkLli0H7cz\nDc7hJuQ0e2gUuKzqSvEajlf9+GQsQqAPbLP3m6K9STNiA0rlAk6Xj3B9zWfSz+oC\n52tYImaB0JtekkJ4/JIvUbafeVNh9ny0PHqhsHZEAQKBgQDFO2Wca5NZ3wvpZuzH\nmzo3y6g9ojtvOepEPPd0K/Xs1SgoEnNSi2sBZ0dwCD23tBqVNgJ93YQ6lpGz2sWx\nGWldUj7AutVXEEqaDA5kXOwN0o0pTvb4WEhoBokV17oeBPY5OTkNJzQt2W87idUL\nHIla+DFN3yoZyQqsPdfppqssAQKBgQC296NON2ZkcEPQxDUMELifjF3iLpcOCfT5\nXJy2s/BXJ+jPeiwtq88urE6WFZrLAyIEouMfQwwYTtqIUlpaZxwzGEnFExcjwqYS\n8NJFJZcEN9ECPkrUV8BpiAFXk+3q9FTW+qL1Y+tHkMlAk/YvcwmCZbbTLTaqP6eI\nOclKPX3vwwKBgQCkUHqz2S+WdOtQlQ34sYrMByBv0KOhY2eXWA90OleU6nSdBdoL\nz9ji/28Vl9gLHsHyw19KCu1pfh1+8Gk4xQnx1F4xZLXt5cWxFxA6buu+DEbMPlwk\nxC/2clNs3h/ReKLFQ7YTDjE7bWVs/cR+kFSidBlnXd+OQd5hZthlcRQ0AQKBgQCH\nq9D4KrROPcDLiPIc5DlCdX8YPJvd2RxB256JC5xnxDwpvNoNc5zJaxNKzvJdHxGW\nhoILqFfLno0FEKvW5SZP7O6mp6U86xTibpg8lccJZaoiE7bBBeCzYBo+qn58/nf6\ngRddBp5sDrxsmkqunIqsmmea56flThYYOWE9H6PGqQKBgAG4Gi5MhL0KcZzyn0vf\nmAm4poSxCqjKjMuNLFeMDFKtgP1SUunVrF63+fRPdfIKe2he7y6+L7qiCCO9fc0A\nLnbG1BO8HriINhhzqXVh35Q/gIV++2KWePxnL+FP98bOYlAcCNo/zJNKBa3YowMB\ntV/hPSJ0ea6d+p0X1IGmuCrE\n-----END PRIVATE KEY-----\n"",
          ""client_email"": ""firebase-adminsdk-3wof0@smartrental-hub.iam.gserviceaccount.com"",
          ""client_id"": ""109935992877622232957"",
          ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
          ""token_uri"": ""https://oauth2.googleapis.com/token"",
          ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
          ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-3wof0%40smartrental-hub.iam.gserviceaccount.com"",
          ""universe_domain"": ""googleapis.com""
        }";

        static string filepath = "";
        public static FirestoreDb database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, fireconfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            database = FirestoreDb.Create("smartrental-hub");
            File.Delete(filepath);

        }
    }
}
            