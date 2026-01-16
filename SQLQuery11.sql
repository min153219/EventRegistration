INSERT INTO [Event] (Title, Type, EventDate, Location, TotalCapacity, Category, Description, IsFeatured, DateCreated, DateUpdated, CreatedBy, UpdatedBy)
VALUES 
('Tech Talks 2026', 'Professional', '2026-03-10 09:00:00', 'Convention Center', 500, 'Professional',
'Join industry leaders for inspiring talks on emerging technologies, AI innovations, and future trends in tech.', 
1, GETDATE(), GETDATE(), 'System', 'System');

DECLARE @TechTalksId INT = SCOPE_IDENTITY();

INSERT INTO [Event] (Title, Type, EventDate, Location, TotalCapacity, Category, Description, IsFeatured, DateCreated, DateUpdated, CreatedBy, UpdatedBy)
VALUES 
('Indie Film Festival', 'Entertainment', '2026-04-05 18:00:00', 'Downtown Theater', 300, 'Entertainment',
'Experience the best independent films from around the world. A celebration of creative storytelling and artistic vision.',
1, GETDATE(), GETDATE(), 'System', 'System');

DECLARE @IndieFilmId INT = SCOPE_IDENTITY();

INSERT INTO [Event] (Title, Type, EventDate, Location, TotalCapacity, Category, Description, IsFeatured, DateCreated, DateUpdated, CreatedBy, UpdatedBy)
VALUES 
('City Marathon 2026', 'Sports', '2026-05-12 07:00:00', 'City Streets', 1000, 'Sports',
'Join thousands of runners in Singapore''s premier marathon event. Challenge yourself and make a difference!',
1, GETDATE(), GETDATE(), 'System', 'System');

DECLARE @MarathonId INT = SCOPE_IDENTITY();

INSERT INTO [Event] (Title, Type, EventDate, Location, TotalCapacity, Category, Description, IsFeatured, DateCreated, DateUpdated, CreatedBy, UpdatedBy)
VALUES 
('Summer Music Festival 2026', 'Music', '2026-07-15 17:00:00', 'Central Park', 2000, 'Music',
'Live performances, festivals, and music events featuring top local and international artists.',
1, GETDATE(), GETDATE(), 'System', 'System');

DECLARE @MusicFestId INT = SCOPE_IDENTITY();

INSERT INTO [Event] (Title, Type, EventDate, Location, TotalCapacity, Category, Description, IsFeatured, DateCreated, DateUpdated, CreatedBy, UpdatedBy)
VALUES 
('Modern Art Exhibition', 'Arts', '2026-01-20 10:00:00', 'City Gallery', 200, 'Arts',
'Exhibitions, theater, and cultural events celebrating modern and contemporary art from local and international artists.',
1, GETDATE(), GETDATE(), 'System', 'System');

DECLARE @ArtExhibitId INT = SCOPE_IDENTITY();



DECLARE @TechTalksId INT = (SELECT Id FROM Event WHERE Title = 'Tech Talks 2026');
DECLARE @IndieFilmId INT = (SELECT Id FROM Event WHERE Title = 'Indie Film Festival');
DECLARE @MarathonId INT = (SELECT Id FROM Event WHERE Title = 'City Marathon 2026');
DECLARE @MusicFestId INT = (SELECT Id FROM Event WHERE Title = 'Summer Music Festival 2026');
DECLARE @ArtExhibitId INT = (SELECT Id FROM Event WHERE Title = 'Modern Art Exhibition');

INSERT INTO [Ticket] (Price, Type, EventId, DateCreated, DateUpdated, CreatedBy, UpdatedBy)
VALUES 
(75.00, 'General Admission', @TechTalksId, GETDATE(), GETDATE(), 'System', 'System'),
(120.00, 'VIP Pass', @TechTalksId, GETDATE(), GETDATE(), 'System', 'System');

INSERT INTO [Ticket] (Price, Type, EventId, DateCreated, DateUpdated, CreatedBy, UpdatedBy)
VALUES 
(35.00, 'Standard Ticket', @IndieFilmId, GETDATE(), GETDATE(), 'System', 'System'),
(25.00, 'Student Ticket', @IndieFilmId, GETDATE(), GETDATE(), 'System', 'System');

INSERT INTO [Ticket] (Price, Type, EventId, DateCreated, DateUpdated, CreatedBy, UpdatedBy)
VALUES 
(50.00, 'Runner Registration', @MarathonId, GETDATE(), GETDATE(), 'System', 'System');

INSERT INTO [Ticket] (Price, Type, EventId, DateCreated, DateUpdated, CreatedBy, UpdatedBy)
VALUES 
(45.00, 'General Admission', @MusicFestId, GETDATE(), GETDATE(), 'System', 'System'),
(80.00, 'VIP Access', @MusicFestId, GETDATE(), GETDATE(), 'System', 'System'),
(30.00, 'Early Bird', @MusicFestId, GETDATE(), GETDATE(), 'System', 'System');

INSERT INTO [Ticket] (Price, Type, EventId, DateCreated, DateUpdated, CreatedBy, UpdatedBy)
VALUES 
(0.00, 'Free Admission', @ArtExhibitId, GETDATE(), GETDATE(), 'System', 'System');

