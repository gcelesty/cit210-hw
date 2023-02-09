class Randomizer
{
    public List<string> _scripture = new List<string>();

    public string RandomScripture()
    {
        this._scripture.Add(new string("1 Nephi 7:12 Yea, and how is it that ye have forgotten that the Lord is able to do all things according to his will, for the children of men, if it so be that they exercise faith in him? Wherefore, let us be faithful to him."));
        this._scripture.Add(new string("2 Nephi 31:19 And now, my beloved brethren, after ye have gotten into this strait and narrow path, I would ask if all is done? Behold, I say unto you, Nay; for ye have not come thus far save it were by the word of Christ with unshaken faith in him, relying wholly upon the merits of him who is mighty to save."));
        this._scripture.Add(new string("Alma 32:21 And now as I said concerning faith— faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."));
        this._scripture.Add(new string("Ether 12:6 And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith."));
        this._scripture.Add(new string("Ether 7:33 And Christ hath said: If ye will have faith in me ye shall have power to do whatsoever thing is expedient in me."));
        
        int index = new Random().Next(0, this._scripture.Count() -1);
        String ranScripture = this._scripture[index];

        return ranScripture;
    }
}