[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/yWedu6XH)

# 📚 Calculadora con Historial en C#

Este proyecto es una calculadora de consola desarrollada en .NET que permite realizar operaciones matemáticas básicas (+, −, ×, ÷) y mantiene un historial de las operaciones realizadas.

---

## 🛠️ Tecnologías utilizadas

- Lenguaje: **C#**
- Plataforma: **.NET Console Application**
- IDE recomendado: **Visual Studio / VS Code**
- Versionado: **Git**

---

## ✅ Funcionalidades

- Sumar, restar, multiplicar y dividir números.
- Evita divisiones por cero.
- Permite reiniciar el valor actual de la calculadora.
- Guarda un historial de todas las operaciones realizadas.
- Muestra el historial completo con resultados intermedios.
- Permite ingresar un nuevo valor inicial tras limpiar.

---

## 🧠 Estructura del proyecto

- `Operacion.cs`: Define la clase `Operacion` y el `enum TipoOperacion` para representar el tipo de cálculo.
- `Calculadora.cs`: Contiene la lógica principal de la calculadora, operaciones y el historial.
- `CalculadoraManager.cs`: Gestiona la interacción con el usuario desde la consola.
- `Program.cs`: Punto de entrada del programa, donde se inicia el `CalculadoraManager`.

---

## ▶️ Cómo ejecutar

1. Cloná el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/CalculadoraHistorial.git
   cd CalculadoraHistorial
2. Ejecutar linea de codigo:
  dotnet run
