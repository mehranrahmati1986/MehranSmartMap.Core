# MehranSmartMap

A lightweight package for automatic AutoMapper profile discovery and mapping registration in ASP.NET Core. It allows you to define mapping logic in isolated classes and register everything automatically.

---

## 🌐 English

### 🔧 Installation & Configuration

#### 1. Install Package

```bash
dotnet add package MehranSmartMap
```

#### 2. Define Your Mapping Class

```csharp
public class UserMap : BaseMap<UserDto, User>
{
    protected override bool EnableReverseMap => true;

    public override void CustomMappings(IMappingExpression<UserDto, User> mapping, IMappingExpression<User, UserDto> reverseMap)
    {
        mapping.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName));
    }
}
```

#### 3. Register It in Program.cs / Startup.cs

```csharp
builder.Services.AddMehranSmartMap(opt =>
{
    opt.ScanAssemblies = new[] { typeof(UserMap).Assembly };
});

var app = builder.Build();

// for MehranSmartMap.Core
ServiceLocator.SetLocatorProvider(app.Services);
```

#### 4. Use the Mapping

```csharp
var entity = dto.ToEntity<User>();
var dto = entity.ToDto<UserDto>();
```

---

## 🇮🇷 فارسی

### 📦 نصب و پیکربندی

#### ۱. نصب پکیج:

```bash
dotnet add package MehranSmartMap
```

#### ۲. تعریف نگاشت:

```csharp
public class UserMap : BaseMap<UserDto, User>
{
    protected override bool EnableReverseMap => true;

    public override void CustomMappings(IMappingExpression<UserDto, User> mapping, IMappingExpression<User, UserDto> reverseMap)
    {
        mapping.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName));
    }
}
```

#### ۳. ثبت در برنامه:

```csharp
builder.Services.AddMehranSmartMap(opt =>
{
    opt.ScanAssemblies = new[] { typeof(UserMap).Assembly };
});

var app = builder.Build();

// for MehranSmartMap.Core
ServiceLocator.SetLocatorProvider(app.Services);
```

#### ۴. استفاده از مپ:

```csharp
var entity = dto.ToEntity<User>();
var dto = entity.ToDto<UserDto>();
```

---

## 🇸🇦 العربية

### ⚙️ التثبيت والتكوين

#### ١. تثبيت الحزمة:

```bash
dotnet add package MehranSmartMap
```

#### ٢. تعريف التحويل:

```csharp
public class UserMap : BaseMap<UserDto, User>
{
    protected override bool EnableReverseMap => true;

    public override void CustomMappings(IMappingExpression<UserDto, User> mapping, IMappingExpression<User, UserDto> reverseMap)
    {
        mapping.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.FullName));
    }
}
```

#### ٣. تسجيل الحزمة:

```csharp
builder.Services.AddMehranSmartMap(opt =>
{
    opt.ScanAssemblies = new[] { typeof(UserMap).Assembly };
});

var app = builder.Build();

// for MehranSmartMap.Core
ServiceLocator.SetLocatorProvider(app.Services);
```

#### ٤. استخدام الخرائط:

```csharp
var entity = dto.ToEntity<User>();
var dto = entity.ToDto<UserDto>();
```

---

## ✅ Features

- Auto-registers all mapping classes implementing `IMapDefinition`
- Reverse mapping support
- Clean and maintainable
- Easy to test and extend

---

Made with ❤️ by Mehran Ghaederahmat
