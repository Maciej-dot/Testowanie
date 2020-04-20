using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Movie
    {
        private int id { get; }
        private string title { get; set; }
        private string description { get; set; }
        private MovieState movieState { get; set; }
        private MovieType movieType { get; set; }
        private TimeSpan movieTime { get; set; }
        private bool flgVR { get; set; }
        private bool flg2D { get; set; }
        private bool flg3D { get; set; }
        private List<PersonJob> peoples;
        public Movie(string t, string d, MovieState ms, MovieType mt, TimeSpan time,
                    bool fv, bool f2, bool f3)
        {
            title = t;
            description = d;
            movieState = ms;
            movieType = mt;
            movieTime = time;
            flgVR = fv;
            flg2D = f2;
            flg3D = f3;
            peoples = new List<PersonJob>();
        }

        public void addPerson(PersonJob pj)
        {
            peoples.Add(pj);
            pj.movie = this;
        }

        public string toString()
        {
            return "\"" + title + "\", " + description;
        }
    }
}
