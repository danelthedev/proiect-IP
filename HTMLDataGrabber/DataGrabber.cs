/**************************************************************************
 *                                                                        *
 *  File:        DataGrabber.cs                                           *
 *  Copyright:   (c) 2023, Imbrea Daniel                                  *
 *  E-mail:      daniel.imbrea2@student.tuiasi.ro                         *
 *  Description: It represents the class used to retrieve the information *
 *               from formula 1 website. It can be used with any site.    *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HTMLDataGrabber
{
    /// <summary>
    /// Class used to retrieve the information from formula 1 website.
    /// </summary>
    public class DataGrabber
    {
        private string _url;
        
        /// <summary>
        /// Sets the page to be used.
        /// </summary>
        /// <param name="url"></param>
        public void SetPage(string url)
        {
            _url = url;
        }

        /// <summary>
        /// Get the text from a specific id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetTextById(string id)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(_url);
            HtmlNode node = doc.GetElementbyId(id);
            return node.InnerText;
        }

        /// <summary>
        /// Get the entire text from a specific xpath.
        /// </summary>
        /// <param name="xpath"></param>
        /// <returns></returns>
        public List<string> GetTextListByXpath(string xpath)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(_url);
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(xpath);
            List<string> list = new List<string>();
            foreach (HtmlNode node in nodes)
            {
                list.Add(node.InnerText);
            }
            return list;
        }

        /// <summary>
        /// Get the text from a specific xpath.
        /// </summary>
        /// <param name="xpath"></param>
        /// <returns></returns>
        public string GetTextByXpath(string xpath)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(_url);
            HtmlNode node = doc.DocumentNode.SelectSingleNode(xpath);
            return node.InnerText;
        }

        /// <summary>
        /// Get the image from website.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        public byte[] DownloadImage(string imageUrl)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    // Download the image data
                    byte[] imageData = client.DownloadData(imageUrl);
                    return imageData;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the download
                Console.WriteLine("Error downloading image: " + ex.Message);
                return null;
            }
        }
    }
}
