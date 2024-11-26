<template>
    <div class="map-container">
      <!-- Input Field for Location -->
      <div class="mb-4">
        <input
          type="text"
          v-model="address"
          placeholder="Enter an address..."
          class="w-full px-4 py-2 border rounded-md border-green-300 focus:outline-none focus:border-green-800"
        />
        <button
          @click="updateMapLocation"
          class="mt-2 px-4 py-2 bg-green-600 text-white rounded-md hover:bg-green-900 focus:outline-none"
        >
          Search Location
        </button>
      </div>
  
      <!-- Map -->
      <div id="map" class="map"></div>
    </div>
  </template>
  
  <script>
  import L from "leaflet";
  
  export default {
    name: "MapView",
    data() {
      return {
        map: null,
        marker: null,
        address: "", // User's input for address
      };
    },
    mounted() {
      this.initMap();
    },
    methods: {
      initMap() {
        // Initialize the map with a default view
        this.map = L.map("map").setView([51.505, -0.09], 13);
  
        // Add OpenStreetMap tiles
        L.tileLayer("https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png", {
          attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors',
        }).addTo(this.map);
  
        // Add a default marker
        this.marker = L.marker([51.505, -0.09]).addTo(this.map).bindPopup("Default Location").openPopup();
      },
      async updateMapLocation() {
        if (!this.address) {
          alert("Please enter an address.");
          return;
        }
  
        try {
          // Fetch coordinates from Nominatim API
          const response = await fetch(
            `https://nominatim.openstreetmap.org/search?q=${encodeURIComponent(this.address)}&format=json`
          );
          const data = await response.json();
  
          if (data.length === 0) {
            alert("Location not found. Please try a different address.");
            return;
          }
  
          // Extract latitude and longitude from the API response
          const { lat, lon } = data[0];
  
          // Update the map's view and marker location
          const latLng = [parseFloat(lat), parseFloat(lon)];
          this.map.setView(latLng, 13);
          this.marker.setLatLng(latLng).bindPopup(this.address).openPopup();
        } catch (error) {
          console.error("Error fetching location:", error);
          alert("An error occurred while fetching the location.");
        }
      },
    },
  };
  </script>
  
  <style scoped>
  .map-container {
    width: 100%;
    height: 100%;
  }
  .map {
    height: 400px;
    width: 100%;
  }
  </style>