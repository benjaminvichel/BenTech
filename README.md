<div align="center">

# 🏨 BentTech - Hotel Daily Rate Calculator

**Eliminating human error in hotel budget quotations — built for enterprise reliability.**

<br/>

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=flat&logo=mysql&logoColor=white)
![BenTech API](https://img.shields.io/badge/BenTech_API-custom-8A2BE2?style=flat)
![Version](https://img.shields.io/badge/version-2.0-0F6E56?style=flat)

> This is **Version 2** of [CSharp-Calculate-Hotel-Daily-Rate](https://github.com/benjaminvichel/CSharp-Calculate-Hotel-Daily-Rate), rebuilt from the ground up with a custom BenTech API, an interactive calendar, and full admin control over pricing.

</div>

---

##  Purpose

Manual pricing in hotel budget workflows is prone to inconsistencies, outdated values, and costly human errors. This application was built to **directly address a real operational need**, automating the daily rate calculation process and reducing human error in budget quotations by up to **99%**.

Rather than relying on spreadsheets or manual lookups, the system centralizes all pricing logic — giving the company a single, reliable source of truth for daily rates across any date range.

---

##  What's New in v2.0

| Feature | v1.0 | v2.0 |
|---------|------|------|
| Daily rate calculation | ✅ | ✅ |
| Data stored in MySQL | ✅ | ✅ |
| Interactive visual calendar | ❌ | ✅ |
| Admin custom pricing per date | ❌ | ✅ |
| Powered by BenTech API | ❌ | ✅ |

### Interactive Calendar
The new version features a fully interactive calendar interface, allowing users to visually navigate dates and instantly see rate values — replacing the plain date input of v1.

### Admin Custom Pricing
Administrators can now create **custom price values** and assign them directly to specific calendar dates. This gives the business full flexibility to define seasonal rates, special event pricing, or any date-specific values — all managed through the system without manual code changes.

###  BenTech API
A dedicated internal API was developed exclusively for this project, handling the communication between the frontend, business logic, and the MySQL database in a structured and scalable way.

---

## ⚙️ How it Works

```
Customer selects date range  →  BenTech API queries MySQL  →  Rate is calculated  →  Result displayed
```

| Step | Role | Description |
|------|------|-------------|
| **01** | Customer | Selects a start and end date on the interactive calendar |
| **02** | BenTech API | Fetches the custom pricing values for each date from MySQL |
| **03** | System | Calculates the total daily rate for the selected period |
| **04** | Customer | Receives the final budget value on screen, error-free |

---

## 🛠️ Tech Stack

- **Language:** C#
- **Database:** MySQL
- **API:** BenTech API *(custom-built for this project)*
- **Interface:** Interactive Calendar UI

---

## 📬 Contact

Found a bug or have a suggestion? Feedback is always welcome.

**Benjamin Vichel** — benni.vichel@hotmail.com

---




<div align="center" style="display: flex; justify-content: center; gap: 20px;">
    <img src="https://github.com/user-attachments/assets/efcd87cf-1315-48a1-a2cb-2e13ea9133c4" width="300px">
    <img src="https://github.com/user-attachments/assets/66cb74f2-f175-4465-a6bf-fea70ccfabf9" width="500px">
</div>

<div align="center" style="display: flex; justify-content: center; gap: 20px;">
    <img src="https://github.com/user-attachments/assets/5a05f0a4-1e0c-4a10-9c51-c6cb316b245e" width="500px">
    <img src="https://github.com/user-attachments/assets/37dbd9d5-43e6-4cf7-9ba2-7cd9ead3a28b" width="500px">
</div>

<div align="center">
  <sub>Built to solve a real problem. Designed to last.</sub>
</div>
