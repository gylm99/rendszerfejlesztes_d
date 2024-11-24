<template>
    <div class="bg-white rounded shadow p-6 space-y-6">
      <h1 class="text-2xl font-bold text-green-600">Advertisement Registration</h1>
  
      <!-- Picture Upload -->
      <div>
        <label class="block text-gray-700 font-bold mb-2">Upload Pictures</label>
        <input
          type="file"
          multiple
          class="block w-full text-gray-500 border border-gray-300 rounded p-2 cursor-pointer"
          @change="handleFileUpload"
        />
        <div class="grid grid-cols-3 gap-4 mt-4">
          <div
            v-for="(file, index) in uploadedFiles"
            :key="index"
            class="relative w-full h-32 bg-gray-100 border border-gray-300 rounded overflow-hidden"
          >
            <img :src="file.preview" alt="Uploaded" class="object-cover w-full h-full" />
            <button
              class="absolute top-2 right-2 text-white bg-red-500 hover:bg-red-700 rounded-full p-1"
              @click="removeFile(index)"
            >
              &times;
            </button>
          </div>
        </div>
      </div>
  
      <!-- Price and Basic Details -->
      <div class="grid grid-cols-1 sm:grid-cols-2 gap-4">
        <div>
          <label class="block text-gray-700 font-bold mb-2">Price (Ft)</label>
          <input
            type="number"
            class="w-full border border-gray-300 rounded p-2"
            v-model="form.price"
          />
        </div>
        <div>
          <label class="block text-gray-700 font-bold mb-2">Base Area (m²)</label>
          <input
            type="number"
            class="w-full border border-gray-300 rounded p-2"
            v-model="form.baseArea"
          />
        </div>
        <div>
          <label class="block text-gray-700 font-bold mb-2">Rooms</label>
          <input
            type="number"
            class="w-full border border-gray-300 rounded p-2"
            v-model="form.rooms"
          />
        </div>
        <div>
          <label class="block text-gray-700 font-bold mb-2">Built Year</label>
          <input
            type="number"
            class="w-full border border-gray-300 rounded p-2"
            v-model="form.builtYear"
          />
        </div>
      </div>
  
      <!-- Dropdowns -->
      <div class="grid grid-cols-1 sm:grid-cols-3 gap-4">
        <div>
          <label class="block text-gray-700 font-bold mb-2">Condition</label>
          <select class="w-full border border-gray-300 rounded p-2" v-model="form.condition">
            <option value="" disabled>Select Condition</option>
            <option>New</option>
            <option>Good</option>
            <option>Needs Renovation</option>
          </select>
        </div>
        <div>
          <label class="block text-gray-700 font-bold mb-2">Floor Level</label>
          <input
            type="number"
            class="w-full border border-gray-300 rounded p-2"
            v-model="form.floorLevel"
          />
        </div>
        <div>
          <label class="block text-gray-700 font-bold mb-2">Main Building Floor Levels</label>
          <input
            type="number"
            class="w-full border border-gray-300 rounded p-2"
            v-model="form.mainBuildingFloors"
          />
        </div>
        <div>
          <label class="block text-gray-700 font-bold mb-2">Elevator</label>
          <select class="w-full border border-gray-300 rounded p-2" v-model="form.elevator">
            <option value="" disabled>Select Elevator Option</option>
            <option>Yes</option>
            <option>No</option>
          </select>
        </div>
        <div>
          <label class="block text-gray-700 font-bold mb-2">Orientation</label>
          <select class="w-full border border-gray-300 rounded p-2" v-model="form.orientation">
            <option value="" disabled>Select Orientation</option>
            <option>North</option>
            <option>East</option>
            <option>South</option>
            <option>West</option>
          </select>
        </div>
      </div>
  
      <!-- Description -->
      <div>
        <label class="block text-gray-700 font-bold mb-2">Description</label>
        <textarea
          class="w-full border border-gray-300 rounded p-2"
          rows="4"
          v-model="form.description"
        ></textarea>
      </div>
  
      <!-- Address -->
      <div>
        <label class="block text-gray-700 font-bold mb-2">Address</label>
        <input
          type="text"
          class="w-full border border-gray-300 rounded p-2"
          v-model="form.address"
        />
      </div>
  
      <!-- Submit Button -->
      <div class="text-right">
        <button
          class="bg-green-600 hover:bg-green-700 text-white font-bold py-2 px-4 rounded"
          @click="submitForm"
        >
          Submit
        </button>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        form: {
          price: '',
          baseArea: '',
          rooms: '',
          builtYear: '',
          condition: '',
          floorLevel: '',
          mainBuildingFloors: '',
          elevator: '',
          orientation: '',
          description: '',
          address: '',
        },
        uploadedFiles: [],
      };
    },
    methods: {
      handleFileUpload(event) {
        const files = Array.from(event.target.files);
        files.forEach((file) => {
          const reader = new FileReader();
          reader.onload = (e) => {
            this.uploadedFiles.push({ file, preview: e.target.result });
          };
          reader.readAsDataURL(file);
        });
      },
      removeFile(index) {
        this.uploadedFiles.splice(index, 1);
      },
      submitForm() {
        console.log('Form Submitted:', this.form, 'Uploaded Files:', this.uploadedFiles);
        alert('Form submitted!');
      },
    },
  };
  </script>