
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/02/2017 14:56:00
-- Generated from EDMX file: C:\Users\sawak\Desktop\Ipleiria\2º Semestre\Desenvolvimento de aplicações\Repositorio\Base\WindowsFormsApp1\WindowsFormsApp1\DiagramaEntidadesArcmage.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BaseDados];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RefereeGame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GameSet] DROP CONSTRAINT [FK_RefereeGame];
GO
IF OBJECT_ID(N'[dbo].[FK_DeckGame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GameSet] DROP CONSTRAINT [FK_DeckGame];
GO
IF OBJECT_ID(N'[dbo].[FK_DeckGame1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GameSet] DROP CONSTRAINT [FK_DeckGame1];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTeamGame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GameSet_TeamGame] DROP CONSTRAINT [FK_TeamTeamGame];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTeamGame1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GameSet_TeamGame] DROP CONSTRAINT [FK_TeamTeamGame1];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTournamentTeamGame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GameSet_TeamGame] DROP CONSTRAINT [FK_TeamTournamentTeamGame];
GO
IF OBJECT_ID(N'[dbo].[FK_StandadTournamentStardadGame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GameSet_StardadGame] DROP CONSTRAINT [FK_StandadTournamentStardadGame];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerStardadGame]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GameSet_StardadGame] DROP CONSTRAINT [FK_PlayerStardadGame];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerStardadGame1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GameSet_StardadGame] DROP CONSTRAINT [FK_PlayerStardadGame1];
GO
IF OBJECT_ID(N'[dbo].[FK_DeckDeck_Card]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Deck_CardSet] DROP CONSTRAINT [FK_DeckDeck_Card];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTournament_TeamTeamTournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamTournament_TeamSet] DROP CONSTRAINT [FK_TeamTournament_TeamTeamTournament];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTournament_TeamTeam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamTournament_TeamSet] DROP CONSTRAINT [FK_TeamTournament_TeamTeam];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamPlayer_Team]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamPlayer] DROP CONSTRAINT [FK_TeamPlayer_Team];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamPlayer_Player]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TeamPlayer] DROP CONSTRAINT [FK_TeamPlayer_Player];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerStandadTournament_Player]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlayerStandadTournament] DROP CONSTRAINT [FK_PlayerStandadTournament_Player];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerStandadTournament_StandadTournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PlayerStandadTournament] DROP CONSTRAINT [FK_PlayerStandadTournament_StandadTournament];
GO
IF OBJECT_ID(N'[dbo].[FK_CardDeck_Card]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Deck_CardSet] DROP CONSTRAINT [FK_CardDeck_Card];
GO
IF OBJECT_ID(N'[dbo].[FK_Referee_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet_Referee] DROP CONSTRAINT [FK_Referee_inherits_User];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamGame_inherits_Game]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GameSet_TeamGame] DROP CONSTRAINT [FK_TeamGame_inherits_Game];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamTournament_inherits_Tournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TournamentSet_TeamTournament] DROP CONSTRAINT [FK_TeamTournament_inherits_Tournament];
GO
IF OBJECT_ID(N'[dbo].[FK_StandadTournament_inherits_Tournament]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TournamentSet_StandadTournament] DROP CONSTRAINT [FK_StandadTournament_inherits_Tournament];
GO
IF OBJECT_ID(N'[dbo].[FK_StardadGame_inherits_Game]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GameSet_StardadGame] DROP CONSTRAINT [FK_StardadGame_inherits_Game];
GO
IF OBJECT_ID(N'[dbo].[FK_Administrator_inherits_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet_Administrator] DROP CONSTRAINT [FK_Administrator_inherits_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CardSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CardSet];
GO
IF OBJECT_ID(N'[dbo].[DeckSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DeckSet];
GO
IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[GameSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GameSet];
GO
IF OBJECT_ID(N'[dbo].[TeamSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeamSet];
GO
IF OBJECT_ID(N'[dbo].[TournamentSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TournamentSet];
GO
IF OBJECT_ID(N'[dbo].[PlayerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlayerSet];
GO
IF OBJECT_ID(N'[dbo].[Deck_CardSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Deck_CardSet];
GO
IF OBJECT_ID(N'[dbo].[TeamTournament_TeamSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeamTournament_TeamSet];
GO
IF OBJECT_ID(N'[dbo].[UserSet_Referee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet_Referee];
GO
IF OBJECT_ID(N'[dbo].[GameSet_TeamGame]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GameSet_TeamGame];
GO
IF OBJECT_ID(N'[dbo].[TournamentSet_TeamTournament]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TournamentSet_TeamTournament];
GO
IF OBJECT_ID(N'[dbo].[TournamentSet_StandadTournament]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TournamentSet_StandadTournament];
GO
IF OBJECT_ID(N'[dbo].[GameSet_StardadGame]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GameSet_StardadGame];
GO
IF OBJECT_ID(N'[dbo].[UserSet_Administrator]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet_Administrator];
GO
IF OBJECT_ID(N'[dbo].[TeamPlayer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeamPlayer];
GO
IF OBJECT_ID(N'[dbo].[PlayerStandadTournament]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PlayerStandadTournament];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CardSet'
CREATE TABLE [dbo].[CardSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Faction] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Loyalty] int  NOT NULL,
    [Defense] int  NOT NULL,
    [Cost] int  NOT NULL,
    [RuleText] nvarchar(max)  NOT NULL,
    [Attack] int  NOT NULL
);
GO

-- Creating table 'DeckSet'
CREATE TABLE [dbo].[DeckSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'GameSet'
CREATE TABLE [dbo].[GameSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Date] time  NOT NULL,
    [Number] int  NOT NULL,
    [RefereeId] int  NULL,
    [DeckIOneld] int  NULL,
    [DeckITwold] int  NULL
);
GO

-- Creating table 'TeamSet'
CREATE TABLE [dbo].[TeamSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TournamentSet'
CREATE TABLE [dbo].[TournamentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Date] time  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PlayerSet'
CREATE TABLE [dbo].[PlayerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Nickname] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Deck_CardSet'
CREATE TABLE [dbo].[Deck_CardSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DeckId] int  NOT NULL,
    [CardId] int  NOT NULL,
    [Quantity] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TeamTournament_TeamSet'
CREATE TABLE [dbo].[TeamTournament_TeamSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TeamTournament_Id] int  NOT NULL,
    [Team_Id] int  NOT NULL
);
GO

-- Creating table 'UserSet_Referee'
CREATE TABLE [dbo].[UserSet_Referee] (
    [Name] nvarchar(max)  NOT NULL,
    [Avatar] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'GameSet_TeamGame'
CREATE TABLE [dbo].[GameSet_TeamGame] (
    [TeamId] int  NULL,
    [TeamId1] int  NULL,
    [TeamTournamentId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'TournamentSet_TeamTournament'
CREATE TABLE [dbo].[TournamentSet_TeamTournament] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'TournamentSet_StandadTournament'
CREATE TABLE [dbo].[TournamentSet_StandadTournament] (
    [Id] int  NOT NULL
);
GO

-- Creating table 'GameSet_StardadGame'
CREATE TABLE [dbo].[GameSet_StardadGame] (
    [StandadTournamentId] int  NOT NULL,
    [PlayerId] int  NULL,
    [PlayerId1] int  NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'UserSet_Administrator'
CREATE TABLE [dbo].[UserSet_Administrator] (
    [Email] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'TeamPlayer'
CREATE TABLE [dbo].[TeamPlayer] (
    [Team_Id] int  NOT NULL,
    [Player_Id] int  NOT NULL
);
GO

-- Creating table 'PlayerStandadTournament'
CREATE TABLE [dbo].[PlayerStandadTournament] (
    [Player_Id] int  NOT NULL,
    [StandadTournament_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CardSet'
ALTER TABLE [dbo].[CardSet]
ADD CONSTRAINT [PK_CardSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DeckSet'
ALTER TABLE [dbo].[DeckSet]
ADD CONSTRAINT [PK_DeckSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GameSet'
ALTER TABLE [dbo].[GameSet]
ADD CONSTRAINT [PK_GameSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TeamSet'
ALTER TABLE [dbo].[TeamSet]
ADD CONSTRAINT [PK_TeamSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TournamentSet'
ALTER TABLE [dbo].[TournamentSet]
ADD CONSTRAINT [PK_TournamentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PlayerSet'
ALTER TABLE [dbo].[PlayerSet]
ADD CONSTRAINT [PK_PlayerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Deck_CardSet'
ALTER TABLE [dbo].[Deck_CardSet]
ADD CONSTRAINT [PK_Deck_CardSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TeamTournament_TeamSet'
ALTER TABLE [dbo].[TeamTournament_TeamSet]
ADD CONSTRAINT [PK_TeamTournament_TeamSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet_Referee'
ALTER TABLE [dbo].[UserSet_Referee]
ADD CONSTRAINT [PK_UserSet_Referee]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GameSet_TeamGame'
ALTER TABLE [dbo].[GameSet_TeamGame]
ADD CONSTRAINT [PK_GameSet_TeamGame]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TournamentSet_TeamTournament'
ALTER TABLE [dbo].[TournamentSet_TeamTournament]
ADD CONSTRAINT [PK_TournamentSet_TeamTournament]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TournamentSet_StandadTournament'
ALTER TABLE [dbo].[TournamentSet_StandadTournament]
ADD CONSTRAINT [PK_TournamentSet_StandadTournament]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GameSet_StardadGame'
ALTER TABLE [dbo].[GameSet_StardadGame]
ADD CONSTRAINT [PK_GameSet_StardadGame]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet_Administrator'
ALTER TABLE [dbo].[UserSet_Administrator]
ADD CONSTRAINT [PK_UserSet_Administrator]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Team_Id], [Player_Id] in table 'TeamPlayer'
ALTER TABLE [dbo].[TeamPlayer]
ADD CONSTRAINT [PK_TeamPlayer]
    PRIMARY KEY CLUSTERED ([Team_Id], [Player_Id] ASC);
GO

-- Creating primary key on [Player_Id], [StandadTournament_Id] in table 'PlayerStandadTournament'
ALTER TABLE [dbo].[PlayerStandadTournament]
ADD CONSTRAINT [PK_PlayerStandadTournament]
    PRIMARY KEY CLUSTERED ([Player_Id], [StandadTournament_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [RefereeId] in table 'GameSet'
ALTER TABLE [dbo].[GameSet]
ADD CONSTRAINT [FK_RefereeGame]
    FOREIGN KEY ([RefereeId])
    REFERENCES [dbo].[UserSet_Referee]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RefereeGame'
CREATE INDEX [IX_FK_RefereeGame]
ON [dbo].[GameSet]
    ([RefereeId]);
GO

-- Creating foreign key on [DeckIOneld] in table 'GameSet'
ALTER TABLE [dbo].[GameSet]
ADD CONSTRAINT [FK_DeckGame]
    FOREIGN KEY ([DeckIOneld])
    REFERENCES [dbo].[DeckSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeckGame'
CREATE INDEX [IX_FK_DeckGame]
ON [dbo].[GameSet]
    ([DeckIOneld]);
GO

-- Creating foreign key on [DeckITwold] in table 'GameSet'
ALTER TABLE [dbo].[GameSet]
ADD CONSTRAINT [FK_DeckGame1]
    FOREIGN KEY ([DeckITwold])
    REFERENCES [dbo].[DeckSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeckGame1'
CREATE INDEX [IX_FK_DeckGame1]
ON [dbo].[GameSet]
    ([DeckITwold]);
GO

-- Creating foreign key on [TeamId] in table 'GameSet_TeamGame'
ALTER TABLE [dbo].[GameSet_TeamGame]
ADD CONSTRAINT [FK_TeamTeamGame]
    FOREIGN KEY ([TeamId])
    REFERENCES [dbo].[TeamSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamTeamGame'
CREATE INDEX [IX_FK_TeamTeamGame]
ON [dbo].[GameSet_TeamGame]
    ([TeamId]);
GO

-- Creating foreign key on [TeamId1] in table 'GameSet_TeamGame'
ALTER TABLE [dbo].[GameSet_TeamGame]
ADD CONSTRAINT [FK_TeamTeamGame1]
    FOREIGN KEY ([TeamId1])
    REFERENCES [dbo].[TeamSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamTeamGame1'
CREATE INDEX [IX_FK_TeamTeamGame1]
ON [dbo].[GameSet_TeamGame]
    ([TeamId1]);
GO

-- Creating foreign key on [TeamTournamentId] in table 'GameSet_TeamGame'
ALTER TABLE [dbo].[GameSet_TeamGame]
ADD CONSTRAINT [FK_TeamTournamentTeamGame]
    FOREIGN KEY ([TeamTournamentId])
    REFERENCES [dbo].[TournamentSet_TeamTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamTournamentTeamGame'
CREATE INDEX [IX_FK_TeamTournamentTeamGame]
ON [dbo].[GameSet_TeamGame]
    ([TeamTournamentId]);
GO

-- Creating foreign key on [StandadTournamentId] in table 'GameSet_StardadGame'
ALTER TABLE [dbo].[GameSet_StardadGame]
ADD CONSTRAINT [FK_StandadTournamentStardadGame]
    FOREIGN KEY ([StandadTournamentId])
    REFERENCES [dbo].[TournamentSet_StandadTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StandadTournamentStardadGame'
CREATE INDEX [IX_FK_StandadTournamentStardadGame]
ON [dbo].[GameSet_StardadGame]
    ([StandadTournamentId]);
GO

-- Creating foreign key on [PlayerId] in table 'GameSet_StardadGame'
ALTER TABLE [dbo].[GameSet_StardadGame]
ADD CONSTRAINT [FK_PlayerStardadGame]
    FOREIGN KEY ([PlayerId])
    REFERENCES [dbo].[PlayerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerStardadGame'
CREATE INDEX [IX_FK_PlayerStardadGame]
ON [dbo].[GameSet_StardadGame]
    ([PlayerId]);
GO

-- Creating foreign key on [PlayerId1] in table 'GameSet_StardadGame'
ALTER TABLE [dbo].[GameSet_StardadGame]
ADD CONSTRAINT [FK_PlayerStardadGame1]
    FOREIGN KEY ([PlayerId1])
    REFERENCES [dbo].[PlayerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerStardadGame1'
CREATE INDEX [IX_FK_PlayerStardadGame1]
ON [dbo].[GameSet_StardadGame]
    ([PlayerId1]);
GO

-- Creating foreign key on [DeckId] in table 'Deck_CardSet'
ALTER TABLE [dbo].[Deck_CardSet]
ADD CONSTRAINT [FK_DeckDeck_Card]
    FOREIGN KEY ([DeckId])
    REFERENCES [dbo].[DeckSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeckDeck_Card'
CREATE INDEX [IX_FK_DeckDeck_Card]
ON [dbo].[Deck_CardSet]
    ([DeckId]);
GO

-- Creating foreign key on [TeamTournament_Id] in table 'TeamTournament_TeamSet'
ALTER TABLE [dbo].[TeamTournament_TeamSet]
ADD CONSTRAINT [FK_TeamTournament_TeamTeamTournament]
    FOREIGN KEY ([TeamTournament_Id])
    REFERENCES [dbo].[TournamentSet_TeamTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamTournament_TeamTeamTournament'
CREATE INDEX [IX_FK_TeamTournament_TeamTeamTournament]
ON [dbo].[TeamTournament_TeamSet]
    ([TeamTournament_Id]);
GO

-- Creating foreign key on [Team_Id] in table 'TeamTournament_TeamSet'
ALTER TABLE [dbo].[TeamTournament_TeamSet]
ADD CONSTRAINT [FK_TeamTournament_TeamTeam]
    FOREIGN KEY ([Team_Id])
    REFERENCES [dbo].[TeamSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamTournament_TeamTeam'
CREATE INDEX [IX_FK_TeamTournament_TeamTeam]
ON [dbo].[TeamTournament_TeamSet]
    ([Team_Id]);
GO

-- Creating foreign key on [Team_Id] in table 'TeamPlayer'
ALTER TABLE [dbo].[TeamPlayer]
ADD CONSTRAINT [FK_TeamPlayer_Team]
    FOREIGN KEY ([Team_Id])
    REFERENCES [dbo].[TeamSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Player_Id] in table 'TeamPlayer'
ALTER TABLE [dbo].[TeamPlayer]
ADD CONSTRAINT [FK_TeamPlayer_Player]
    FOREIGN KEY ([Player_Id])
    REFERENCES [dbo].[PlayerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamPlayer_Player'
CREATE INDEX [IX_FK_TeamPlayer_Player]
ON [dbo].[TeamPlayer]
    ([Player_Id]);
GO

-- Creating foreign key on [Player_Id] in table 'PlayerStandadTournament'
ALTER TABLE [dbo].[PlayerStandadTournament]
ADD CONSTRAINT [FK_PlayerStandadTournament_Player]
    FOREIGN KEY ([Player_Id])
    REFERENCES [dbo].[PlayerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [StandadTournament_Id] in table 'PlayerStandadTournament'
ALTER TABLE [dbo].[PlayerStandadTournament]
ADD CONSTRAINT [FK_PlayerStandadTournament_StandadTournament]
    FOREIGN KEY ([StandadTournament_Id])
    REFERENCES [dbo].[TournamentSet_StandadTournament]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerStandadTournament_StandadTournament'
CREATE INDEX [IX_FK_PlayerStandadTournament_StandadTournament]
ON [dbo].[PlayerStandadTournament]
    ([StandadTournament_Id]);
GO

-- Creating foreign key on [CardId] in table 'Deck_CardSet'
ALTER TABLE [dbo].[Deck_CardSet]
ADD CONSTRAINT [FK_CardDeck_Card]
    FOREIGN KEY ([CardId])
    REFERENCES [dbo].[CardSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CardDeck_Card'
CREATE INDEX [IX_FK_CardDeck_Card]
ON [dbo].[Deck_CardSet]
    ([CardId]);
GO

-- Creating foreign key on [Id] in table 'UserSet_Referee'
ALTER TABLE [dbo].[UserSet_Referee]
ADD CONSTRAINT [FK_Referee_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'GameSet_TeamGame'
ALTER TABLE [dbo].[GameSet_TeamGame]
ADD CONSTRAINT [FK_TeamGame_inherits_Game]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[GameSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'TournamentSet_TeamTournament'
ALTER TABLE [dbo].[TournamentSet_TeamTournament]
ADD CONSTRAINT [FK_TeamTournament_inherits_Tournament]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[TournamentSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'TournamentSet_StandadTournament'
ALTER TABLE [dbo].[TournamentSet_StandadTournament]
ADD CONSTRAINT [FK_StandadTournament_inherits_Tournament]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[TournamentSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'GameSet_StardadGame'
ALTER TABLE [dbo].[GameSet_StardadGame]
ADD CONSTRAINT [FK_StardadGame_inherits_Game]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[GameSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'UserSet_Administrator'
ALTER TABLE [dbo].[UserSet_Administrator]
ADD CONSTRAINT [FK_Administrator_inherits_User]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------