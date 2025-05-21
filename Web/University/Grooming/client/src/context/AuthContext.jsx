import React, { createContext, useState } from "react";

export const AuthContext = createContext({
  user: null,
  login: async () => {},
  logout: () => {}
});

export function AuthProvider({ children }) {
  const [user, setUser] = useState(null);

  async function login({ login, password }) {
    // здесь вы будете дергать API; пока — просто мок
    setUser({ login, fullName: login === "admin" ? "Администратор" : login, role: login === "admin" ? "admin" : "user" });
  }

  function logout() {
    setUser(null);
  }

  return (
    <AuthContext.Provider value={{ user, login, logout }}>
      {children}
    </AuthContext.Provider>
  );
}
