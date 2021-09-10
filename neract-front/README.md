# Neract 0.1.0

Neract is a very simple content management tool. It handles one list of Articles that may be written by one of any number of users. The public can only read the articles from the
list, and do simple searching. The "content-creator" users have a spartan interface for adding, editing, and removing articles. This "Admin" section can only be accessed via the 
/api/v1/login route with a successful login (all "content-creator" users are defined in MongoDB behind the .NET 5 WebApi Server.) The UI will not be super-slick, and isn't intended
to ever look super-slick.


### Why's this so basic and lame?

I doubt anyone will want this as a product, but Neract is a solid playground for enhancing my .NET Core WebAPI 4 knowledge and expanding my React 17 skills.
