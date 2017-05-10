<Query Kind="Statements">
  <Connection>
    <ID>fe0351f7-4513-41bd-bf78-549437c31de6</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in Artists
            where m.ArtistId==1
            orderby m.Name
			select new
			{
			Artist = m.Name,
			Albums = from t in m.Albums
			orderby t.Title
			select new
				{
			      Title = t.Title,
				  Tracks = from tr in t.Tracks
				           select new
					{
					TrackName = tr.Name,
					GenreId = tr.GenreId,
					Composer = tr.Composer,
					Milliseconds = tr.Milliseconds
					}
			    }
			};
results.Dump();