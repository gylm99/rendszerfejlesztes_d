<template>
    <div class="bg-white shadow rounded-lg overflow-hidden transform hover:scale-105 transition duration-300 ease-in-out">
                    <div class="relative inline-block">
                        <span class="bg-green-200 text-green-800 text-xs font-semibold px-2 py-1 rounded absolute top-2 left-2">For Sale</span>
                        <img src="https://images.pexels.com/photos/106399/pexels-photo-106399.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" alt="Product Image" class="w-full h-48 object-cover">
                    </div>
                     <div class="grid grid-cols-3  px-4 pt-1">
                        <h3 class="text-md font-semibold mb-2">50,90 M Ft</h3>
                        <h3 class="text-md font-semibold mb-2">Base area</h3>
                        <h3 class="text-md font-semibold mb-2">Balcony</h3>
                    </div>
                    <div class="grid grid-cols-3 px-4 py-0">
                        <h3>Szeged, Rákóczi utca 20</h3>
                        <p class="text-gray-600">29 m<sup>2</sup></p>
                        <p class="text-gray-600">11 m<sup>2</sup></p>
                    </div>
                </div>
</template>

<script>
export default {
  name: 'ItemShow',
  
}

</script>