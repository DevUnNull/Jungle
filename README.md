# 🎮 Jungle Exam - 2D Action Platformer Game

[![Unity](https://img.shields.io/badge/Unity-6000.0.60f1-000000?logo=unity)](https://unity.com/)
[![C#](https://img.shields.io/badge/C%23-11.0-239120?logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

Một game 2D Action Platformer được phát triển bằng Unity, kết hợp các cơ chế gameplay đa dạng với hệ thống nâng cấp linh hoạt và kiến trúc code được tổ chức tốt.

---

## 📋 Mục Lục

- [Tổng Quan](#-tổng-quan)
- [Tính Năng Chính](#-tính-năng-chính)
- [Cơ Chế Game](#-cơ-chế-game)
- [Công Nghệ Sử Dụng](#-công-nghệ-sử-dụng)
- [Design Patterns](#-design-patterns)
- [Cấu Trúc Project](#-cấu-trúc-project)
- [Hướng Dẫn Cài Đặt](#-hướng-dẫn-cài-đặt)
- [Điểm Mạnh Của Project](#-điểm-mạnh-của-project)
- [Hình Ảnh Demo](#-hình-ảnh-demo)

---

## 🎯 Tổng Quan

**Jungle Exam** là một game 2D Action Platformer nơi người chơi điều khiển nhân vật chiến đấu với các enemy liên tục xuất hiện. Game có hệ thống level up và upgrade phong phú, cho phép người chơi tùy chỉnh và phát triển nhân vật theo nhiều cách khác nhau.

### Thể Loại
- **2D Action Platformer**
- **Roguelike Elements** (Progressive difficulty, upgrade system)
- **Survival Gameplay**

---

## ✨ Tính Năng Chính

### 🎮 Gameplay
- ✅ **Hệ thống di chuyển linh hoạt**: Chạy, nhảy đôi, dash với hiệu ứng ghost
- ✅ **Combat system**: Bắn đạn, skill đặc biệt với cooldown
- ✅ **Enemy AI**: Enemy tự động tìm và tấn công player
- ✅ **Progressive Difficulty**: Độ khó tăng dần theo thời gian
- ✅ **Score System**: Hệ thống điểm số với lưu best score

### 📈 Hệ Thống Nâng Cấp
- ✅ **6 loại upgrade**: Health, Speed, Damage, Attack Speed, Critical Chance, Shield
- ✅ **Level Up System**: Tích lũy EXP để lên cấp và chọn upgrade
- ✅ **Dynamic Stats**: Thống kê nhân vật thay đổi theo upgrade

### 🎨 UI/UX
- ✅ **Health Bar**: Hiển thị máu real-time
- ✅ **Level Bar**: Thanh EXP và level hiện tại
- ✅ **Upgrade Selection UI**: Giao diện chọn upgrade khi lên cấp
- ✅ **Pause Menu**: Tạm dừng, restart, về home
- ✅ **Game Over Screen**: Hiển thị điểm và best score

### 🔊 Audio System
- ✅ **Background Music**: Nhạc nền tự động phát và loop
- ✅ **Sound Effects**: Hiệu ứng âm thanh cho các hành động
- ✅ **Audio Mixer**: Quản lý volume và mixing

---

## 🎲 Cơ Chế Game

### Core Gameplay Loop

1. **Sinh Tồn**: Player phải sống sót trước các đợt enemy liên tục xuất hiện
2. **Tiêu Diệt Enemy**: Bắn và tiêu diệt enemy để nhận EXP
3. **Level Up**: Tích lũy đủ EXP để lên cấp
4. **Chọn Upgrade**: Mỗi level up cho phép chọn 1 trong 3 upgrade ngẫu nhiên
5. **Tăng Độ Khó**: Enemy spawn nhanh hơn theo thời gian
6. **High Score**: Cố gắng đạt điểm cao nhất có thể

### Player Mechanics

#### Di Chuyển
- **Horizontal Movement**: Di chuyển trái/phải với tốc độ có thể nâng cấp
- **Double Jump**: Nhảy đôi với số lần nhảy tối đa
- **Dash**: Kỹ năng dash tăng tốc độ tạm thời với hiệu ứng ghost trail
- **Ground Detection**: Kiểm tra va chạm với mặt đất bằng Physics2D

#### Combat
- **Shooting**: Bắn đạn theo hướng chuột với fire rate có thể nâng cấp
- **Skill Shot**: Kỹ năng đặc biệt với cooldown 5 giây
- **Damage System**: Sát thương có thể tăng qua upgrade
- **Critical Hit**: Tỷ lệ chí mạng có thể nâng cấp

### Enemy System

- **Spawn System**: Enemy spawn liên tục trong bán kính xung quanh spawner
- **AI Behavior**: Enemy tự động tìm và di chuyển về phía player
- **Damage on Contact**: Enemy gây sát thương khi tiếp xúc với player
- **Health System**: Enemy có máu riêng, nhận sát thương từ đạn

### Upgrade System

Hệ thống upgrade được thiết kế theo **Factory Pattern** và **Strategy Pattern**:

- **Health Upgrade**: Tăng máu tối đa
- **Speed Upgrade**: Tăng % tốc độ di chuyển (multiplier)
- **Damage Upgrade**: Tăng sát thương cơ bản
- **Attack Speed Upgrade**: Tăng % tốc độ bắn (multiplier)
- **Critical Chance Upgrade**: Tăng tỷ lệ chí mạng
- **Shield Upgrade**: Tăng shield bảo vệ

Mỗi upgrade được tạo thông qua `UpgradeFactory` và implement interface `IUpgrade`.

---

## 💻 Công Nghệ Sử Dụng

### Game Engine & Framework
- **Unity Engine**: Version 6000.0.60f1
- **Unity 2D**: Hệ thống 2D physics và rendering
- **C#**: Ngôn ngữ lập trình chính

### Unity Packages & Modules
- **Unity UI (uGUI)**: Hệ thống UI
- **TextMesh Pro**: Text rendering chất lượng cao
- **Physics2D**: Hệ thống vật lý 2D
- **Animation System**: Animator Controller cho player và enemy
- **Audio System**: AudioSource, AudioMixer
- **Scene Management**: Quản lý scene và chuyển cảnh
- **PlayerPrefs**: Lưu trữ dữ liệu local (best score)

### Development Tools
- **Visual Studio / Rider**: IDE phát triển
- **Git**: Version control
- **Unity Collab**: Collaboration tools

### Kiến Trúc Code
- **Component-Based Architecture**: Sử dụng Unity's component system
- **MonoBehaviour**: Base class cho các script game object
- **Coroutines**: Xử lý các tác vụ bất đồng bộ
- **Events & Delegates**: Communication giữa các components

---

## 🏗️ Design Patterns

Project này áp dụng các **Design Patterns** cơ bản và quan trọng trong game development:

### 1. **Singleton Pattern** 🎯
**Mục đích**: Đảm bảo chỉ có một instance duy nhất của các manager quan trọng

**Triển khai**:
- `GameManager`: Quản lý trạng thái game, score, game over
- `_AudioManager`: Quản lý audio toàn cục, persist qua các scene

```csharp
// Ví dụ từ GameManager.cs
public static GameManager instance;
private void Awake()
{
    if(instance == null)
    {
        instance = this;
    }
    else
    {
        Destroy(gameObject);
    }
}
```

**Lợi ích**:
- Truy cập global dễ dàng
- Tránh duplicate instances
- Quản lý state tập trung

### 2. **Factory Pattern** 🏭
**Mục đích**: Tạo các đối tượng upgrade mà không cần biết class cụ thể

**Triển khai**:
- `UpgradeFactory`: Tạo các loại upgrade khác nhau dựa trên `UpgradeData`

```csharp
// Ví dụ từ UpgradeFactory.cs
public static IUpgrade Create(UpgradeData data)
{
    switch (data.upgradeType)
    {
        case "Health":
            return new HealthUpgrade(...);
        case "Speed":
            return new SpeedUpgrade(...);
        // ...
    }
}
```

**Lợi ích**:
- Tách biệt logic tạo object
- Dễ mở rộng thêm loại upgrade mới
- Code dễ maintain

### 3. **Strategy Pattern** 🎲
**Mục đích**: Định nghĩa các thuật toán (upgrade) có thể thay thế lẫn nhau

**Triển khai**:
- `IUpgrade` interface: Định nghĩa contract chung
- Các class cụ thể: `HealthUpgrade`, `SpeedUpgrade`, `DamageUpgrade`, etc.

```csharp
// Interface định nghĩa strategy
public interface IUpgrade
{
    string Name { get; }
    string Description { get; }
    Sprite Icon { get; }
    void Apply(InformationPlayer player);
}

// Các strategy cụ thể
public class HealthUpgrade : IUpgrade { ... }
public class SpeedUpgrade : IUpgrade { ... }
```

**Lợi ích**:
- Dễ thêm loại upgrade mới
- Tách biệt logic từng loại upgrade
- Runtime có thể chọn strategy

### 4. **Component Pattern** 🧩
**Mục đích**: Tổ chức code theo component, mỗi component có trách nhiệm riêng

**Triển khai**:
- `Move`: Xử lý di chuyển và combat
- `HealthPlayer`: Quản lý máu
- `InformationPlayer`: Lưu trữ stats
- `Enemy`: Logic enemy
- `Bullet`: Hành vi đạn

**Lợi ích**:
- Code modular, dễ tái sử dụng
- Dễ test và debug
- Tuân theo Single Responsibility Principle

### 5. **Observer Pattern** (Implicit) 👁️
**Mục đích**: Cập nhật UI khi game state thay đổi

**Triển khai**:
- `GameUI`: Cập nhật UI dựa trên game state
- `HealthBar`: Cập nhật thanh máu khi health thay đổi
- `LevelUp`: Thông báo khi đủ EXP

**Lợi ích**:
- Loose coupling giữa game logic và UI
- Dễ thêm observer mới

---

## 📁 Cấu Trúc Project

```
Assets/
├── _MyGame/                    # Main game folder
│   ├── Scrip/                  # Scripts
│   │   ├── GameManager.cs      # Singleton: Quản lý game state
│   │   ├── Move.cs             # Player movement & combat
│   │   ├── Enemy.cs            # Enemy behavior
│   │   ├── EnemySpamner.cs     # Enemy spawning system
│   │   ├── HealthPlayer.cs     # Health system
│   │   ├── LevelUp.cs          # Level & EXP system
│   │   ├── _AudioManager.cs    # Singleton: Audio management
│   │   ├── GameUI.cs           # UI controller
│   │   ├── PauseGame.cs        # Pause menu
│   │   └── UpDrade/            # Upgrade system
│   │       ├── IUpgrade.cs     # Strategy interface
│   │       ├── UpgradeFactory.cs  # Factory pattern
│   │       ├── UpgradeManager.cs  # Upgrade management
│   │       ├── UpgradeUI.cs    # Upgrade selection UI
│   │       ├── InformationPlayer.cs  # Player stats
│   │       └── UpgradeData.cs  # ScriptableObject data
│   ├── Animation/              # Animator controllers
│   ├── Art/                    # Sprites & graphics
│   ├── Prefabs/                # Game object prefabs
│   ├── Scene/                  # Game scenes
│   └── Audi Mixer/             # Audio mixer settings
├── TextMesh Pro/               # TextMesh Pro assets
└── Assets/                     # Additional assets
    ├── Sounds/                 # Audio files
    └── Sprites/                # Sprite assets
```

### Key Scripts Overview

| Script | Mô Tả | Pattern |
|--------|-------|---------|
| `GameManager` | Quản lý score, game over, best score | Singleton |
| `_AudioManager` | Quản lý background music và sound effects | Singleton |
| `UpgradeFactory` | Tạo các upgrade object | Factory |
| `IUpgrade` | Interface cho các upgrade | Strategy |
| `UpgradeManager` | Quản lý danh sách upgrade và apply | Manager |
| `Move` | Player movement, shooting, dash | Component |
| `EnemySpamner` | Spawn enemy với progressive difficulty | Spawner |
| `LevelUp` | EXP và level up system | Component |

---

## 🚀 Hướng Dẫn Cài Đặt

### Yêu Cầu Hệ Thống
- **Unity Editor**: Version 6000.0.60f1 hoặc tương thích
- **OS**: Windows, macOS, hoặc Linux
- **RAM**: Tối thiểu 4GB (khuyến nghị 8GB)
- **Disk Space**: ~2GB cho project

### Các Bước Cài Đặt

1. **Clone Repository**
   ```bash
   git clone <repository-url>
   cd Exam_1
   ```

2. **Mở Project trong Unity**
   - Mở Unity Hub
   - Chọn "Add" và trỏ đến thư mục project
   - Unity sẽ tự động import packages

3. **Chạy Game**
   - Mở scene `Assets/_MyGame/Scene/Home.unity`
   - Nhấn Play trong Unity Editor
   - Hoặc build và chạy executable

### Điều Khiển

- **A/D hoặc Mũi Tên Trái/Phải**: Di chuyển
- **Space hoặc W**: Nhảy
- **Click Chuột Trái**: Bắn đạn
- **Click Chuột Phải**: Dash
- **Q**: Skill đặc biệt (cooldown 5s)
- **ESC**: Pause menu
- **T**: Test - Thêm 1 EXP (chỉ trong editor)

---

## 🌟 Điểm Mạnh Của Project

### 1. **Kiến Trúc Code Tốt** 🏗️
- ✅ Áp dụng các Design Patterns phù hợp
- ✅ Code được tổ chức rõ ràng, dễ maintain
- ✅ Separation of concerns: Mỗi class có trách nhiệm riêng
- ✅ Sử dụng Interface và Abstract để tăng tính linh hoạt

### 2. **Hệ Thống Upgrade Linh Hoạt** 📈
- ✅ Factory Pattern cho phép dễ dàng thêm loại upgrade mới
- ✅ Strategy Pattern cho phép mỗi upgrade có logic riêng
- ✅ ScriptableObject cho data-driven design
- ✅ Hệ thống có thể mở rộng mà không cần sửa code cũ

### 3. **Gameplay Đa Dạng** 🎮
- ✅ Nhiều cơ chế gameplay: movement, combat, upgrade, progression
- ✅ Progressive difficulty tạo challenge tăng dần
- ✅ Hệ thống level up và upgrade tạo replayability

### 4. **Quản Lý State Tốt** 🎯
- ✅ Singleton Pattern cho global managers
- ✅ PlayerPrefs cho persistent data
- ✅ Game state management rõ ràng

### 5. **Audio System Hoàn Chỉnh** 🔊
- ✅ Background music với auto-loop
- ✅ Sound effects cho các hành động
- ✅ Audio Mixer integration
- ✅ DontDestroyOnLoad cho audio persist

### 6. **UI/UX Chuyên Nghiệp** 🎨
- ✅ Health bar và level bar real-time
- ✅ Upgrade selection UI với icon và description
- ✅ Pause menu đầy đủ tính năng
- ✅ Game over screen với best score

### 7. **Performance Optimization** ⚡
- ✅ Sử dụng Object Pooling pattern (có thể mở rộng)
- ✅ Efficient enemy spawning với progressive difficulty
- ✅ Optimized update loops với Time.deltaTime checks

### 8. **Code Quality** 📝
- ✅ Naming conventions rõ ràng
- ✅ Comments và documentation
- ✅ Error handling với null checks
- ✅ Debug logs cho development

### 9. **Scalability** 📊
- ✅ Dễ thêm loại upgrade mới
- ✅ Dễ thêm loại enemy mới
- ✅ Dễ thêm tính năng mới nhờ component architecture
- ✅ Data-driven design với ScriptableObject

### 10. **Best Practices** ✅
- ✅ Tuân theo Unity best practices
- ✅ Sử dụng SerializeField thay vì public khi có thể
- ✅ Component-based architecture
- ✅ Proper use of Unity lifecycle methods

---

## 📸 Hình Ảnh Demo

> **Lưu ý**: Thêm screenshots hoặc GIF của game vào đây để showcase tốt hơn

### Các Screenshot Nên Có:
- 🎮 Gameplay screenshot
- 📈 Upgrade selection UI
- 🎯 Combat moment
- 📊 Game over screen với score
- 🏠 Home screen

---

## 🔮 Tính Năng Có Thể Mở Rộng

### Ý Tưởng Cải Tiến:
- [ ] Object Pooling cho bullets và enemies
- [ ] Thêm nhiều loại enemy với behavior khác nhau
- [ ] Boss fights
- [ ] Multiple levels/maps
- [ ] Achievement system
- [ ] Save/Load system với JSON
- [ ] Mobile controls support
- [ ] Particle effects cho combat
- [ ] More upgrade types
- [ ] Weapon variety system

---

## 📚 Kiến Thức Áp Dụng

### Design Patterns
- ✅ Singleton Pattern
- ✅ Factory Pattern
- ✅ Strategy Pattern
- ✅ Component Pattern
- ✅ Observer Pattern (implicit)

### OOP Principles
- ✅ Encapsulation
- ✅ Inheritance
- ✅ Polymorphism
- ✅ Abstraction

### Unity Concepts
- ✅ MonoBehaviour lifecycle
- ✅ Component system
- ✅ Physics2D
- ✅ Animation system
- ✅ Audio system
- ✅ UI system
- ✅ Scene management
- ✅ Prefabs và Instantiation
- ✅ Coroutines
- ✅ PlayerPrefs

### Game Development Concepts
- ✅ Game state management
- ✅ Spawn system
- ✅ Upgrade/progression system
- ✅ Score system
- ✅ Health system
- ✅ Combat system
- ✅ Difficulty scaling

---

## 👨‍💻 Tác Giả

**Developer**: [Tên của bạn]

**Email**: [Email của bạn]

**GitHub**: [GitHub profile]

---

## 📄 License

This project is licensed under the MIT License - see the LICENSE file for details.

---

## 🙏 Lời Cảm Ơn

- Unity Technologies cho Unity Engine
- Cộng đồng Unity developers
- Tất cả những người đã đóng góp ý kiến và feedback

---

## 📞 Liên Hệ

Nếu có câu hỏi hoặc muốn hợp tác, vui lòng liên hệ qua:
- **Email**: [Email]
- **GitHub Issues**: [Repository Issues]

---

**⭐ Nếu project này hữu ích, hãy star repository này! ⭐**

