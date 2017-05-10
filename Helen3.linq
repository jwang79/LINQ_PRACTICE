<Query Kind="Statements">
  <Connection>
    <ID>fe0351f7-4513-41bd-bf78-549437c31de6</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
              where m.Name.Equals("Heavy Metal")
			  select new
			  {
			    TracksCount = m.Tracks.Count(),
				TrackId = from t in m.Tracks
				         select new
				{
				   TrackName = t.Name,
				   AlbumName = t.Album.Title,
				   Milliseconds = t. Milliseconds,
				   Size = (t.Bytes / 1000)+" kb",
				   Price = t.UnitPrice
				   }
			};
			results.Dump("More Math");