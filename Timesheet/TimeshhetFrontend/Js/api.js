const API_BASE = "https://localhost:7170/api";

async function apiFetch(url, options = {}) {
  const token = localStorage.getItem("token");
  const headers = {
    "Content-Type": "application/json",
    ...(token && { Authorization: `Bearer ${token}` }),
    ...options.headers
  };

  const res = await fetch(`${API_BASE}${url}`, { ...options, headers });
  if (res.status === 401) {
    alert("Unauthorized. Please login again.");
    localStorage.clear();
    window.location.href = "index.html";
    return;
  }
  return res;
}
