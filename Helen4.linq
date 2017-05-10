<Query Kind="Statements">
  <Connection>
    <ID>fe0351f7-4513-41bd-bf78-549437c31de6</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in Genres
              orderby m.Name
			  select new
			   {
			     Genre = m.Name,
				 TracksCount = m.Tracks.Count()
			   };
results.Dump("Query Math");