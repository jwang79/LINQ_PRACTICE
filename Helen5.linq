<Query Kind="Statements">
  <Connection>
    <ID>fe0351f7-4513-41bd-bf78-549437c31de6</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
			  select new
			  {
			    Name = m.Name,
				Tracks = from t in m.Tracks
				         select new
				{
				   TrackName = t.Name,
				   Album = t.Album.Title,
				   GenreId = t.Genre.Name,
				   Artist = t.Album.Artist.Name,
				   ReleaseYear = t.Album.ReleaseYear,
				   ReleaseLabel = t.Album. ReleaseLabel ,
				   }
			};
			results.Dump();