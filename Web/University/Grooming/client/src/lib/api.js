import axios from "axios";

const api = axios.create({
  baseURL: "/api", // или ваш адрес: http://localhost:4000/api
  headers: { "Content-Type": "application/json" }
});

export async function login({ login, password }) {
  const res = await api.post("/auth/login", { login, password });
  return res.data; // { token, user }
}

export async function register(data) {
  const res = await api.post("/auth/register", data);
  return res.data; // { token, user }
}

export async function getProfile(token) {
  const res = await api.get("/auth/profile", {
    headers: { Authorization: `Bearer ${token}` }
  });
  return res.data;
}

export async function getAppointments(token) {
  const res = await api.get("/appointments", {
    headers: { Authorization: `Bearer ${token}` }
  });
  return res.data;
}

export async function createAppointment(token, formData) {
  const res = await api.post("/appointments", formData, {
    headers: {
      Authorization: `Bearer ${token}`,
      "Content-Type": "multipart/form-data"
    }
  });
  return res.data;
}

export async function deleteAppointment(token, id) {
  await api.delete(`/appointments/${id}`, {
    headers: { Authorization: `Bearer ${token}` }
  });
}

export async function updateAppointmentStatus(token, id, status, photo) {
  const form = new FormData();
  form.append("status", status);
  if (photo) form.append("photo", photo);
  const res = await api.patch(`/admin/appointments/${id}`, form, {
    headers: {
      Authorization: `Bearer ${token}`,
      "Content-Type": "multipart/form-data"
    }
  });
  return res.data;
}
