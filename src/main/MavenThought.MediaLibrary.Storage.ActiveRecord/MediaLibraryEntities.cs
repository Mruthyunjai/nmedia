﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaLibrary.Core.Model.ActiveRecord {
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using Castle.ActiveRecord;
    
    
    [ActiveRecord("login", Schema="dbo")]
    public partial class Login : ActiveRecordBase<Login> {
        
        private int _id;
        
        private string _loginId;
        
        private string _password;
        
        private User _user;
        
        [PrimaryKey(PrimaryKeyType.Native, "id", ColumnType="Int32")]
        public virtual int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Property("login", ColumnType="Char", NotNull=true)]
        public virtual string LoginId {
            get {
                return this._loginId;
            }
            set {
                this._loginId = value;
            }
        }
        
        [Property("password", ColumnType="Char", NotNull=true)]
        public virtual string Password {
            get {
                return this._password;
            }
            set {
                this._password = value;
            }
        }
        
        [BelongsTo("user_id")]
        public virtual User User {
            get {
                return this._user;
            }
            set {
                this._user = value;
            }
        }
    }
    
    [ActiveRecord("users", Schema="dbo")]
    public partial class User : ActiveRecordBase<User> {
        
        private int _id;
        
        private string _firstName;
        
        private string _lastName;
        
        private IList<Login> _logins;
        
        private IList<Media> _media;
        
        [PrimaryKey(PrimaryKeyType.Native, "id", ColumnType="Int32")]
        public virtual int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Property("first_name", ColumnType="Char", NotNull=true)]
        public virtual string FirstName {
            get {
                return this._firstName;
            }
            set {
                this._firstName = value;
            }
        }
        
        [Property("last_name", ColumnType="Char", NotNull=true)]
        public virtual string LastName {
            get {
                return this._lastName;
            }
            set {
                this._lastName = value;
            }
        }
        
        [HasMany(typeof(Login), ColumnKey="user_id", Table="login")]
        public virtual IList<Login> Logins {
            get {
                return this._logins;
            }
            set {
                this._logins = value;
            }
        }
        
        [HasAndBelongsToMany(typeof(Media), ColumnRef="media_id", ColumnKey="user_id", Schema="dbo", Table="UsersMedia")]
        public virtual IList<Media> Media {
            get {
                return this._media;
            }
            set {
                this._media = value;
            }
        }
    }
    
    [ActiveRecord("media", Schema="dbo")]
    public partial class Media : ActiveRecordBase<Media> {
        
        private int _id;
        
        private string _title;
        
        private System.DateTime _releaseDate;
        
        private System.DateTime _addedDate;
        
        private IList<Review> _reviews;
        
        private SearchEngine _searchEngine;
        
        private IList<User> _medias;
        
        [PrimaryKey(PrimaryKeyType.Native, "id", ColumnType="Int32")]
        public virtual int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Property("title", ColumnType="Char", NotNull=true)]
        public virtual string Title {
            get {
                return this._title;
            }
            set {
                this._title = value;
            }
        }
        
        [Property("release_date", ColumnType="Timestamp", NotNull=true)]
        public virtual System.DateTime ReleaseDate {
            get {
                return this._releaseDate;
            }
            set {
                this._releaseDate = value;
            }
        }
        
        [Property("added_date", ColumnType="Timestamp", NotNull=true)]
        public virtual System.DateTime AddedDate {
            get {
                return this._addedDate;
            }
            set {
                this._addedDate = value;
            }
        }
        
        [HasMany(typeof(Review), ColumnKey="media_id", Table="reviews")]
        public virtual IList<Review> Reviews {
            get {
                return this._reviews;
            }
            set {
                this._reviews = value;
            }
        }
        
        [BelongsTo("search_engine_id")]
        public virtual SearchEngine SearchEngine {
            get {
                return this._searchEngine;
            }
            set {
                this._searchEngine = value;
            }
        }
        
        [HasAndBelongsToMany(typeof(User), ColumnRef="user_id", ColumnKey="media_id", Schema="dbo", Table="UsersMedia")]
        public virtual IList<User> Medias {
            get {
                return this._medias;
            }
            set {
                this._medias = value;
            }
        }
    }
    
    [ActiveRecord("reviews", Schema="dbo")]
    public partial class Review : ActiveRecordBase<Review> {
        
        private int _id;
        
        private string _reviewContent;
        
        private Media _media;
        
        private ReviewEngine _reviewEngine;
        
        [PrimaryKey(PrimaryKeyType.Native, "id", ColumnType="Int32")]
        public virtual int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Property("review", ColumnType="Char", NotNull=true)]
        public virtual string ReviewContent {
            get {
                return this._reviewContent;
            }
            set {
                this._reviewContent = value;
            }
        }
        
        [BelongsTo("media_id")]
        public virtual Media Media {
            get {
                return this._media;
            }
            set {
                this._media = value;
            }
        }
        
        [BelongsTo("review_engine_id")]
        public virtual ReviewEngine ReviewEngine {
            get {
                return this._reviewEngine;
            }
            set {
                this._reviewEngine = value;
            }
        }
    }
    
    [ActiveRecord("review_engines", Schema="dbo")]
    public partial class ReviewEngine : ActiveRecordBase<ReviewEngine> {
        
        private int _id;
        
        private string _title;
        
        private string _description;
        
        private IList<Review> _reviews;
        
        [PrimaryKey(PrimaryKeyType.Native, "id", ColumnType="Int32")]
        public virtual int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Property("title", ColumnType="Char", NotNull=true)]
        public virtual string Title {
            get {
                return this._title;
            }
            set {
                this._title = value;
            }
        }
        
        [Property("description", ColumnType="Char", NotNull=true)]
        public virtual string Description {
            get {
                return this._description;
            }
            set {
                this._description = value;
            }
        }
        
        [HasMany(typeof(Review), ColumnKey="review_engine_id", Table="reviews")]
        public virtual IList<Review> Reviews {
            get {
                return this._reviews;
            }
            set {
                this._reviews = value;
            }
        }
    }
    
    [ActiveRecord("search_engines", Schema="dbo")]
    public partial class SearchEngine : ActiveRecordBase<SearchEngine> {
        
        private int _id;
        
        private string _name;
        
        private string _description;
        
        private IList<Media> _medias;
        
        [PrimaryKey(PrimaryKeyType.Native, "id", ColumnType="Int32")]
        public virtual int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Property("name", ColumnType="Char", NotNull=true)]
        public virtual string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
        
        [Property("description", ColumnType="Char", NotNull=true)]
        public virtual string Description {
            get {
                return this._description;
            }
            set {
                this._description = value;
            }
        }
        
        [HasMany(typeof(Media), ColumnKey="search_engine_id", Table="media")]
        public virtual IList<Media> Medias {
            get {
                return this._medias;
            }
            set {
                this._medias = value;
            }
        }
    }
    
    [ActiveRecord("users_media")]
    public partial class UsersMedia : ActiveRecordBase<UsersMedia> {
        
        private int _id;
        
        private int _userId;
        
        private int _mediaId;
        
        [PrimaryKey(PrimaryKeyType.Native, "id", ColumnType="Int32")]
        public virtual int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Property("user_id", ColumnType="Int32", NotNull=true)]
        public virtual int UserId {
            get {
                return this._userId;
            }
            set {
                this._userId = value;
            }
        }
        
        [Property("media_id", ColumnType="Int32", NotNull=true)]
        public virtual int MediaId {
            get {
                return this._mediaId;
            }
            set {
                this._mediaId = value;
            }
        }
    }
    
    [ActiveRecord("movies", Schema="dbo")]
    public partial class Movies : ActiveRecordBase<Movies> {
        
        private int _id;
        
        private int _mediaId;
        
        [PrimaryKey(PrimaryKeyType.Native, "id", ColumnType="Int32")]
        public virtual int Id {
            get {
                return this._id;
            }
            set {
                this._id = value;
            }
        }
        
        [Property("media_id", ColumnType="Int32", NotNull=true)]
        public virtual int MediaId {
            get {
                return this._mediaId;
            }
            set {
                this._mediaId = value;
            }
        }
    }
}
