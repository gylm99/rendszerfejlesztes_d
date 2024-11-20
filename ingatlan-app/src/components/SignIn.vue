<template>
      <header class="bg-gray-100 py-4 px-6 flex items-center justify-center">
            <!-- Search Bar -->
            <div>
            <router-link to="/">
                <h1 class="text-2xl font-semibold text-gray-800">Real Estate App</h1>
            </router-link> 
            </div>

        </header>
<body class="bg-gray-100 flex items-center justify-center min-h-screen">
    
    <div class="bg-white p-8 rounded-lg shadow-md w-full max-w-sm">
        <h2 class="text-2xl font-bold text-green-600 mb-6 text-center">Bejelentkezés</h2>
        <form action="#" method="POST">
            <div class="mb-4">
                <label for="email" class="block text-sm font-medium text-gray-700">E-mail cím</label>
                <input 
                    type="email" 
                    id="email" 
                    name="email" 
                    class="mt-1 p-2 w-full border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-green-500 focus:border-green-500" 
                    placeholder="pelda@email.com" 
                    required>
            </div>
            <div class="mb-6">
                <label for="password" class="block text-sm font-medium text-gray-700">Jelszó</label>
                <input 
                    type="password" 
                    id="password" 
                    name="password" 
                    class="mt-1 p-2 w-full border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-green-500 focus:border-green-500" 
                    placeholder="••••••••" 
                    required>
            </div>
            <button 
                type="submit" 
                class="w-full bg-green-600 text-white py-2 px-4 rounded-md hover:bg-green-700 transition duration-200">
                Bejelentkezés
            </button>
        </form>
    </div>
</body>
</template>

<script>

</script>