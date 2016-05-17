﻿using RestSharp.Authenticators;

namespace RestSharpInfra.OAuth1 
{
    public class OAuthCompleteInformation 
    {
        public OAuthConsumerInformation ConsumerInformation { get; private set; }
        public string Token { get; private set; }
        public string TokenSecret { get; private set; }

        public OAuthCompleteInformation(string consumerKey, string consumerSecret, string token, string tokenSecret): 
            this(new OAuthConsumerInformation(consumerKey, consumerSecret), token, tokenSecret)
        {
        }

        public OAuthCompleteInformation(OAuthConsumerInformation consumerInformation, string token, string tokenSecret) 
        {
            ConsumerInformation = consumerInformation;
            Token = token;
            TokenSecret = tokenSecret;
        }

        public OAuth1Authenticator GetOAuth1Authenticator() 
        {
            return OAuth1Authenticator.ForProtectedResource(ConsumerInformation.ConsumerKey, ConsumerInformation.ConsumerSecret, Token, TokenSecret);
        }
    }
}