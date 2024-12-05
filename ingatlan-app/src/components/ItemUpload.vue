<template>
  <HeaderNav />
  <div class="min-h-screen bg-gray-100 flex items-center justify-center">
    <form
      @submit.prevent="submitForm"
      class="bg-white p-6 rounded-lg shadow-md w-full max-w-3xl"
    >
      <h2 class="text-2xl font-bold text-green-600 mb-6">Post Your Property</h2>


      <div class="mb-4">
        <label for="price" class="block text-sm font-medium text-gray-700 mb-1">Price ($)</label>
        <input
          id="price"
          type="number"
          v-model="form.price"
          class="block w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-green-200"
          required
        />
      </div>


      <div class="mb-4">
        <label for="saleRent" class="block text-sm font-medium text-gray-700 mb-1">Sale or Rent</label>
        <select
          id="saleRent"
          v-model="form.saleRent"
          class="block w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-green-200"
          required
        >
          <option value="" disabled>Select...</option>
          <option value="Sale">Sale</option>
          <option value="Rent">Rent</option>
        </select>
      </div>


      <div class="grid grid-cols-2 gap-4 mb-4">
        <div>
          <label for="area" class="block text-sm font-medium text-gray-700 mb-1">Area (sqm)</label>
          <input
            id="area"
            type="number"
            v-model="form.area"
            class="block w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-green-200"
            required
          />
        </div>
        <div>
          <label for="rooms" class="block text-sm font-medium text-gray-700 mb-1">Number of Rooms</label>
          <input
            id="rooms"
            type="number"
            v-model="form.rooms"
            class="block w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-green-200"
            required
          />
        </div>
      </div>

      <div class="grid grid-cols-2 gap-4 mb-4">
        <div>
          <label for="condition" class="block text-sm font-medium text-gray-700 mb-1">Condition</label>
          <select
            id="condition"
            v-model="form.condition"
            class="block w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-green-200"
            required
          >
            <option value="" disabled>Select...</option>
            <option value="New">New</option>
            <option value="Used">Used</option>
          </select>
        </div>
        <div>
          <label for="year" class="block text-sm font-medium text-gray-700 mb-1">Year Built</label>
          <input
            id="year"
            type="number"
            v-model="form.year"
            class="block w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-green-200"
            required
          />
        </div>
      </div>


      <div class="grid grid-cols-2 gap-4 mb-4">
        <div>
          <label for="comfort" class="block text-sm font-medium text-gray-700 mb-1">Comfort Level</label>
          <input
            id="comfort"
            type="text"
            v-model="form.comfort"
            class="block w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-green-200"
            required
          />
        </div>
        <div>
          <label for="floor" class="block text-sm font-medium text-gray-700 mb-1">Floor (if applicable)</label>
          <input
            id="floor"
            type="text"
            v-model="form.floor"
            class="block w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-green-200"
          />
        </div>
      </div>

      <div class="grid grid-cols-2 gap-4 mb-4">
        <div>
          <label for="floors" class="block text-sm font-medium text-gray-700 mb-1">Number of Floors</label>
          <input
            id="floors"
            type="number"
            v-model="form.floors"
            class="block w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-green-200"
          />
        </div>
        <div>
          <label for="elevator" class="block text-sm font-medium text-gray-700 mb-1">Has Elevator?</label>
          <select
            id="elevator"
            v-model="form.elevator"
            class="block w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-green-200"
          >
            <option value="Yes">Yes</option>
            <option value="No">No</option>
          </select>
        </div>
      </div>


      <div class="mb-4">
        <label for="orientation" class="block text-sm font-medium text-gray-700 mb-1">Orientation</label>
        <input
          id="orientation"
          type="text"
          v-model="form.orientation"
          class="block w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-green-200"
        />
      </div>


      <div class="mb-6">
        <label for="description" class="block text-sm font-medium text-gray-700 mb-1">Description</label>
        <textarea
          id="description"
          v-model="form.description"
          rows="4"
          class="block w-full p-2 border border-gray-300 rounded-lg focus:ring focus:ring-green-200"
        ></textarea>
      </div>


      <div class="mb-6">
        <label for="images" class="block text-sm font-medium text-gray-700 mb-1">Upload Images</label>
        <input
          id="images"
          type="file"
          multiple
          accept="image/*"
          @change="handleFileUpload"
          class="block w-full text-sm text-gray-900 border border-gray-300 rounded-lg cursor-pointer bg-gray-50 focus:outline-none focus:ring focus:ring-green-200"
        />
        <div v-if="uploadedImages.length" class="mt-4 grid grid-cols-3 gap-4">
          <div v-for="(image, index) in uploadedImages" :key="index" class="relative">
            <img
              :src="image"
              alt="Uploaded Image"
              class="w-full h-32 object-cover rounded-md shadow"
            />
            <button
              @click="removeImage(index)"
              class="absolute top-1 right-1 bg-red-500 text-white rounded-full p-1 text-xs shadow hover:bg-red-600 transition"
              aria-label="Remove image"
            >
              ✕
            </button>
          </div>
        </div>
      </div>


      <div>
        <button
          type="submit"
          class="w-full bg-green-600 text-white py-2 rounded-lg hover:bg-green-700 transition"
        >
          Submit Listing
        </button>
      </div>
    </form>
  </div>
</template>

<script>
import HeaderNav from './HeaderNav.vue';

export default {
  data() {
    return {
      form: {
        price: "",
        saleRent: "",
        area: "",
        rooms: "",
        condition: "",
        year: "",
        comfort: "",
        floor: "",
        floors: "",
        elevator: "No",
        orientation: "",
        description: "",
      },
      uploadedImages: [],
    };
  },
  methods: {
    handleFileUpload(event) {
      const files = event.target.files;
      Array.from(files).forEach((file) => {
        const reader = new FileReader();
        reader.onload = (e) => {
          this.uploadedImages.push(e.target.result);
        };
        reader.readAsDataURL(file);
      });
    },
    removeImage(index) {
      this.uploadedImages.splice(index, 1);
    },
    submitForm() {
      console.log("Form submitted:", this.form, this.uploadedImages);
    },
  },
  components: {
    HeaderNav
  }
};
</script>

---

