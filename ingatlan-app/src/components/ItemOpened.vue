
    <template>
        <header class="bg-gray-100 py-4 px-6 flex items-center justify-center">
<div class="flex items-center space-x-4">
            <router-link to="/">
                <h1 class="text-2xl font-semibold text-gray-800">Real Estate App</h1>
            </router-link> 
        </div>

        </header>
    <div class="bg-gray-100 p-4">
      <div class="max-w-5xl mx-auto bg-white rounded shadow p-6 space-y-6
      ">
        <div>
          <h1 class="text-2xl font-bold text-green-700">{{ propertyTitle }}</h1>
          <h2 class="text-lg text-gray-500 mt-2">{{ propertyLocation }}</h2>
        </div>
  
        <div class="grid grid-cols-3 ">
          <div class="col-span-2">
            <img :src="largeImage" alt="Large" class="rounded shadow">
          </div>
          <div class="space-y-2">
            <img :src="smallImage1" alt="Small 1" class="rounded shadow">
            <img
              :src="smallImage2"
              alt="Small 2"
              class="rounded shadow cursor-pointer"
              @click="showModal = true"
            >
          </div>
        </div>
  
        <div class="grid grid-cols-3 gap-4 text-center mt-4">
          <div>
            <p class="text-lg font-bold text-green-700">Price</p>
            <p class="text-gray-500">{{ propertyPrice }}</p>
          </div>
          <div>
            <p class="text-lg font-bold text-green-700">Base Area</p>
            <p class="text-gray-500">{{ propertyArea }}</p>
          </div>
          <div>
            <p class="text-lg font-bold text-green-700">Rooms</p>
            <p class="text-gray-500">{{ propertyRooms }}</p>
          </div>
        </div>
  
        <div class="space-y-2">
          <h3 class="text-xl font-bold text-green-700">Details</h3>
          <ul class="text-gray-600 space-y-1">
            <li v-for="(value, key) in details" :key="key">
              <strong>{{ key }}:</strong> {{ value }}
            </li>
          </ul>
        </div>
  
        <div>
          <h3 class="text-xl font-bold text-green-700">Description</h3>
          <p class="text-gray-600 mt-2">{{ description }}</p>
        </div>
      </div>
  
      <div
        class="fixed inset-0 bg-black bg-opacity-75 flex items-center justify-center"
        v-show="showModal"
      >
        <div class="bg-white rounded shadow-lg p-6 space-y-4 max-w-4xl w-full relative">
          <button
            @click="showModal = false"
            class="absolute top-2 right-2 text-gray-600 hover:text-gray-800"
          >
            &times;
          </button>
          <h3 class="text-xl font-bold text-green-700">All Pictures</h3>
          <div class="grid grid-cols-3 gap-4">
            <img v-for="(img, index) in allImages" :key="index" :src="img" alt="Gallery" class="rounded shadow">
          </div>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        propertyTitle: "Property Title",
        propertyLocation: "Location or Smaller Title",
        largeImage: "https://via.placeholder.com/600x400",
        smallImage1: "https://via.placeholder.com/200x150",
        smallImage2: "https://via.placeholder.com/200x150",
        propertyPrice: "$250,000",
        propertyArea: "120 m²",
        propertyRooms: "3",
        details: {
          "Condition": "Excellent",
          "Built Year": "2015",
          "Comfort": "Full",
          "Floor Level": "2nd Floor",
          "Main Building Floor Levels": "4",
          "Elevator": "Yes",
          "Orientation": "South"
        },
        description: "This is a beautiful property located in the heart of the city. It offers a spacious living area with modern amenities.",
        showModal: false,
        allImages: [
          "https://via.placeholder.com/300x200",
          "https://via.placeholder.com/300x200",
          "https://via.placeholder.com/300x200",
          "https://via.placeholder.com/300x200",
          "https://via.placeholder.com/300x200",
          "https://via.placeholder.com/300x200"
        ]
      };
    },
    name: "ItemOpened"
  };
  </script>
  
  <style>

  </style>
