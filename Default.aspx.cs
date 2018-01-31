using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
public class ImageClass
{
    private string showImage;
    public string ShowImage
    {
        get
        {
            return showImage;
        }
        set
        {
            showImage = value;
        }
    }
}
public class SeasonClass
{
    private string slug;
    public string Slug
    {
        get
        {
            return slug;
        }
        set
        {
            slug = value;
        }
    }
}
public class NextEpisodeClass
{
    private string channel;
    public string Channel
    {
        get
        {
            return channel;
        }
        set
        {
            channel = value;
        }
    }

    private string channelLogo;
    public string ChannelLogo
    {
        get
        {
            return channelLogo;
        }
        set
        {
            channelLogo = value;
        }
    }

    private string date;
    public string Date
    {
        get
        {
            return date;
        }
        set
        {
            date = value;
        }
    }

    private string html;
    public string HTML
    {
        get
        {
            return html;
        }
        set
        {
            html = value;
        }
    }

    private string url;
    public string URL
    {
        get
        {
            return url;
        }
        set
        {
            url = value;
        }
    }
}
public class TvShow
{ /*adjust so is lined up with nine digital*/
    private string country;
    public string Country
    {
        get
        {
            return country;
        }
        set
        {
            country = value;
        }
    }

   private string description;
    public string Description
    {
        get
        {
            return description;
        }
        set
        {
            description = value;
        }
    }

    private bool drm;
    public bool DRM
    {
        get
        {
            return drm;
        }
        set
        {
            drm = value;
        }
    }

    private int episodeCount;
    public int EpisodeCount
    {
        get
        {
            return episodeCount;
        }
        set
        {
            episodeCount = value;
        }
    }

    private string genre;
    public string Genre
    {
        get
        {
            return genre;
        }
        set
        {
            genre = value;
        }
    }

    private ImageClass image;
    public ImageClass Image
    {
        get
        {
            return image;
        }
        set
        {
            image = value;
        }
    }

    private string language;
    public string Language
    {
        get
        {
            return language;
        }
        set
        {
            language = value;
        }
    }

    private NextEpisodeClass nextEpisode;
    public NextEpisodeClass NextEpisode
    {
        get
        {
            return nextEpisode;
        }
        set
        {
            nextEpisode = value;
        }
    }

    private string primaryColour;
    public string PrimaryColour
    {
        get
        {
            return primaryColour;
        }
        set
        {
            primaryColour = value;
        }
    }

    private SeasonClass[] seasons;
    public SeasonClass[] Seasons
    {
        get
        {
            return seasons;
        }
        set
        {
            seasons = value;
        }
    }

    private string slug;
    public string Slug
    {
        get
        {
            return slug;
        }
        set
        {
            slug = value;
        }
    }

    private string title;
    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            title = value;
        }
    }

    private string tvChannel;
    public string TvChannel
    {
        get
        {
            return tvChannel;
        }
        set
        {
            tvChannel = value;
        }
    } 
}
public class NineDigital
{
    private TvShow[] payload;
    public TvShow[] Payload
    {
        get
        {
            return payload;
        }
        set
        {
            payload = value;
        }
    }
    private int skip;
    public int Skip
    {
        get
        {
            return skip;
        }
        set
        {
            skip = value;
        }
    }
    private int take;
    public int Take
    {
        get
        {
            return take;
        }
        set
        {
            take = value;
        }
    }
    private int totalRecords;
    public int TotalRecords
    {
        get
        {
            return totalRecords;
        }
        set
        {
            totalRecords = value;
        }
    }
}
public class ResponseClass
{
    private string image;
    public string Image
    {
        get
        {
            return image;
        }
        set
        {
            image = value;
        }
    }
    private string slug;
    public string Slug
    {
        get
        {
            return slug;
        }
        set
        {
            slug = value;
        }
    }
    private string title;
    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            title = value;
        }
    }
}
public class ResponseJSON
{
    private ResponseClass[] response;
    public ResponseClass[] Response
    {
        get
        {
            return response;
        }
        set
        {
            response = value;
        }
    }
}

public partial class _Default : System.Web.UI.Page
{
    //[System.Web.Services.WebMethod]
    //public static TvShow GetTvShow(TvShow tvShow)
    //{
    //    return tvShow;
    //}
    [System.Web.Services.WebMethod]
    public static ResponseJSON GetResponse(NineDigital nineDigital)
    {
        ResponseJSON Res = null;
        int responseArrayNo = 0;
        for (int i = 0; i < nineDigital.Payload.Length; i++)
        {
            if (nineDigital.Payload[i].DRM == true && nineDigital.Payload[i].EpisodeCount > 0)
            {          
                responseArrayNo++;
            }
        }
        return Res;
    }
    [System.Web.Services.WebMethod]
    public static NineDigital GetNineDigital(NineDigital nineDigital)
    {
        Debug.WriteLine("Image : " + nineDigital.Payload[0].Image.ShowImage);
        return nineDigital;
    }
    protected void Page_Load(object sender, EventArgs e)
    {


    }
}